using Moq;
using MusicServices.Abstraction;
using MusicServices.Builders;
using MusicServices.ClassTestData;
using MusicServices.Enums;
using MusicServices.Models;
using MusicServices.Utility;

namespace MusicServices
{
    public class HarmonizerTests
    {
        [Theory]
        [ClassData(typeof(ScaleClassData))]
        public void HarmonizeScale_IsDiatonicScale_ReturnsCorrectChords(Scale diatonicScale, IEnumerable<Chord> expectedChords)
        {
            // Arrange
            int expectedChordCount = 7;
            var mockTheoryHelper = new Mock<IMusicTheoryHelper>();
            mockTheoryHelper.Setup(m => m.CheckScaleIsDiatonicFromIntervalPositions(It.IsAny<Scale>()))
            .Returns(true);
            mockTheoryHelper.Setup(m => m.GetChordType(It.IsAny<Chord>()))
            .Returns((Chord chord) =>
            {
                List<int> semitones = chord.ChordNotes.Select(cn => cn.Interval!.SemiTones).ToList();
                string semitoneString = string.Join(", ", semitones);
                string chordType = semitoneString switch
                {
                    "0, 4, 7, 11" => "Major Seventh",
                    "0, 4, 7, 10" => "Dominant Seventh",
                    "0, 3, 7, 10" => "Minor Seventh",
                    "0, 3, 6, 10" => "Minor Seven Flat Five",
                    _ => "Unknown"
                };
                return chordType;
            });

            // Act
            var harmonizer = new Harmonizer(mockTheoryHelper.Object);
            var actualChords = harmonizer.HarmonizeScale(diatonicScale);

            // Assert
            mockTheoryHelper.Verify(m => m.CheckScaleIsDiatonicFromIntervalPositions(diatonicScale), Times.Once);
            Assert.Equal(expectedChordCount, actualChords.Count);
            if (diatonicScale.ScaleType == ScaleTypeEnum.Major.ToString() && diatonicScale.RootNoteName == "C")
            {
                Assert.Equal("Major Seventh", actualChords[0].ChordType);
                Assert.Equal("C", actualChords[0]?.RootNoteName);  // actualChords[0]?.ChordNotes[0]?.Note?.Name
                Assert.Equal("Minor Seventh", actualChords[1].ChordType);
                Assert.Equal("D", actualChords[1].RootNoteName);
                Assert.Equal("Minor Seventh", actualChords[2].ChordType);
                Assert.Equal("E", actualChords[2].RootNoteName);
                Assert.Equal("Major Seventh", actualChords[3].ChordType);
                Assert.Equal("F", actualChords[3].RootNoteName);
                Assert.Equal("Dominant Seventh", actualChords[4].ChordType);
                Assert.Equal("G", actualChords[4].RootNoteName);
                Assert.Equal("Minor Seventh", actualChords[5].ChordType);
                Assert.Equal("A", actualChords[5].RootNoteName);
                Assert.Equal("Minor Seven Flat Five", actualChords[6].ChordType);
                Assert.Equal("B", actualChords[6].RootNoteName);
                // Assert.Equal(expectedChords, actualChords);
            }
            else if (diatonicScale.ScaleType == ScaleTypeEnum.Minor.ToString() && diatonicScale.RootNoteName == "G")
            {
                Assert.Equal("Minor Seventh", actualChords[0].ChordType);
                Assert.Equal("G", actualChords[0].RootNoteName);
                Assert.Equal("Minor Seven Flat Five", actualChords[1].ChordType);
                Assert.Equal("A", actualChords[1].RootNoteName);
                Assert.Equal("Major Seventh", actualChords[2].ChordType);
                Assert.Equal("A#", actualChords[2].RootNoteName);
                Assert.Equal("Minor Seventh", actualChords[3].ChordType);
                Assert.Equal("C", actualChords[3].RootNoteName);
                Assert.Equal("Minor Seventh", actualChords[4].ChordType);
                Assert.Equal("D", actualChords[4].RootNoteName);
                Assert.Equal("Major Seventh", actualChords[5].ChordType);
                Assert.Equal("D#", actualChords[5].RootNoteName);
                Assert.Equal("Dominant Seventh", actualChords[6].ChordType);
                Assert.Equal("F", actualChords[6].RootNoteName);
                // Assert.Equal(expectedChords, actualChords);
            }
        }

        [Fact]
        public void HarmonizeScale_ScaleIsNotDiatonic_ThrowsInvalidDataException()
        {
            var mockTheoryHelper = new Mock<IMusicTheoryHelper>();
            mockTheoryHelper.Setup(m => m.CheckScaleIsDiatonicFromIntervalPositions(It.IsAny<Scale>()))
            .Returns(false);
            Scale scale = new Scale();

            // Act
            var harmonizer = new Harmonizer(mockTheoryHelper.Object);
            var action = () => harmonizer.HarmonizeScale(scale);

            // Assert
            // Assert.Throws<InvalidDataException>(() => harmonizer.HarmonizeScale(scale));
            var exception = Assert.Throws<InvalidDataException>(action);
            Assert.Equal($"Attempting to Harmonize a scale that is not diatonic.", exception.Message);
            
        }
    }
}
