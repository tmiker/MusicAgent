using MusicServices.Builders;
using MusicServices.Enums;
using MusicServices.Helpers;
using MusicServices.Models;
using MusicServices.StaticData;

namespace MusicServices
{
    public class ScaleBuilderTests
    {
        [Fact]
        public void CreateScaleByType_ValidScaleType_ReturnsCorrectScale()
        {
            // Arrange
            string rootNoteName = "C";
            ScaleTypeEnum scaleType = ScaleTypeEnum.Major;
            Scale expectedScale = StaticTestData.GetCMajorScale();
            ScaleBuilder scaleBuilder = new ScaleBuilder(new MusicTheoryHelper());

            // Act
            Scale actualScale = scaleBuilder.CreateScaleByType(rootNoteName, scaleType);

            // Assert
            Assert.NotNull(actualScale);
            Assert.Equal(expectedScale, actualScale);
        }
    }
}
