using MusicServices.Builders;
using MusicServices.Enums;
using MusicServices.Helpers;
using MusicServices.Models;

namespace MusicServices
{
    public class ChordBuilderTests
    {
        [Fact]  // string rootNoteName, ChordTypeEnum chordType
        public void CreateChordByType_ValidChordType_ReturnsCorrectChord()
        {
            // Arrange
            string rootNoteName = "C";
            ChordTypeEnum chordType = ChordTypeEnum.MajorTriad;
            ChordBuilder chordBuilder = new ChordBuilder(new MusicTheoryHelper());

            // Act
            Chord actualChord = chordBuilder.CreateChordByType(rootNoteName, chordType);

            // Assert
            Assert.NotNull(actualChord);
            Assert.Equal(rootNoteName, actualChord.RootNoteName);
            Assert.Equal(3, actualChord.ChordNotes.Count);
            Assert.Equal("C", actualChord.ChordNotes[0].Note.Name);
            Assert.Equal("E", actualChord.ChordNotes[1].Note.Name);
            Assert.Equal("G", actualChord.ChordNotes[2].Note.Name);
        }

        [Fact]  // string rootNoteName, List<int> chordSignature
        public void CreateChordFromSignature_ValidChordSignature_ReturnsCorrectChord()
        {
            // Arrange
            string rootNoteName = "C";
            List<int> chordSignature = new List<int> { 0, 4, 3 }; // Major - intervals are not total, but rather steps from previous interval
            ChordBuilder chordBuilder = new ChordBuilder(new MusicTheoryHelper());

            // Act
            Chord actualChord = chordBuilder.CreateChordFromSignature(rootNoteName, chordSignature);

            // Assert
            Assert.NotNull(actualChord);
            Assert.Equal(rootNoteName, actualChord.RootNoteName);
            Assert.Equal(3, actualChord.ChordNotes.Count);
            Assert.Equal("C", actualChord.ChordNotes[0].Note.Name);
            Assert.Equal("E", actualChord.ChordNotes[1].Note.Name);
            Assert.Equal("G", actualChord.ChordNotes[2].Note.Name);
        }
    }
}
