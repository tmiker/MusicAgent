
using MusicServices.DataStructures;

namespace MusicServices
{
    public class MusicWheelTests
    {
        public static IEnumerable<object[]> GetNextMinorThirdData(int instancesToReturn)
        {
            // object array should contain the following: wheel root note, expected next minor third note from last advanced node
            IEnumerable<object[]> data = new List<object[]>()
            {
                new object[] { "C", "D#" },
                new object[] { "E", "G" },
                new object[] { "G", "A#" },
                new object[] { "A", "C" }
            };

            return data.Take(instancesToReturn);
        }

        public static IEnumerable<object[]> GetNextMajorThirdData(int instancesToReturn)
        {
            // object array should contain the following: wheel root note, expected next minor third note from last advanced node
            IEnumerable<object[]> data = new List<object[]>()
            {
                new object[] { "C", "E" },
                new object[] { "E", "G#" },
                new object[] { "G", "B#" },
                new object[] { "A", "C#" }
            };

            return data.Take(instancesToReturn);
        }

        [Fact]
        public void InitializeMusicWheel_ShouldCreateValidInstance()
        {
            // Arrange 
            string rootNote = "C";

            // Act
            var musicWheel = new MusicWheel(rootNote);
            MusicNode? currentNode = musicWheel.First;


            // Assert
            Assert.NotNull(currentNode);
            Assert.Equal(rootNote, currentNode.Note.Name);
            Assert.Equal("C#", currentNode.Next!.Note.Name);

            for (int i = 1; i < 12; i++)
            {
                currentNode = currentNode.Next;
                Assert.NotNull(currentNode);
            }
            // current node should now be the last node
            Assert.Equal("B", currentNode.Note.Name);
            Assert.Equal(rootNote, currentNode.Next!.Note.Name);
            // Assert that the wheel is circular so previous of first is last
            Assert.Equal(musicWheel.First?.Previous?.Note.Name, currentNode.Note.Name);

        }

        [Theory]
        [InlineData("C", 7, "G")]
        [InlineData("E", 5, "A")]
        public void GetNodeAtSemitoneInterval_ReturnsCorrectNode(string rootNote, int semitonesInterval, string resultNote)
        {
            // Arrange
            var musicWheel = new MusicWheel(rootNote);
            MusicNode? firstNode = musicWheel.First;
            // Act
            MusicNode? nodeAtInterval = musicWheel.GetNodeAtSemitoneInterval(firstNode!, semitonesInterval); 
            // Assert
            Assert.NotNull(nodeAtInterval);
            Assert.Equal(resultNote, nodeAtInterval!.Note.Name);
        }

        [Theory]
        [MemberData(nameof(GetNextMinorThirdData), 2)]
        public void GetNextMinorThird_ReturnsCorrectNode(string wheelRootNote, string expectedNextMinorThirdNote)
        {
            // Arrange
            var musicWheel = new MusicWheel(wheelRootNote);
            MusicNode? firstNode = musicWheel.First;
            // Act
            MusicNode? nextMinorThirdNode = musicWheel.GetNextMinorThird(firstNode!);
            // Assert
            Assert.NotNull(nextMinorThirdNode);
            Assert.Equal(expectedNextMinorThirdNote, nextMinorThirdNode!.Note.Name);
        }

        [Theory]
        [MemberData(nameof(GetNextMajorThirdData), 2)]
        public void GetNextMajorThird_ReturnsCorrectNode(string wheelRootNote, string expectedNextMajorThirdNote)
        {
            // Arrange
            var musicWheel = new MusicWheel(wheelRootNote);
            MusicNode? firstNode = musicWheel.First;
            // Act
            MusicNode? nextMajorThirdNode = musicWheel.GetNextMajorThird(firstNode!);
            // Assert
            Assert.NotNull(nextMajorThirdNode);
            Assert.Equal(expectedNextMajorThirdNote, nextMajorThirdNode!.Note.Name);
        }
    }
}
