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
        public void HarmonizeScale_IsDiatonicScale_ReturnsCorrectChords(Scale diatonicScale, List<Chord> expectedChords)
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

            Assert.Equal(expectedChords, actualChords);
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
