
namespace ColorMapTest.Management.ImagePreProcessing
{
    using ColorMapTest.BasicTest.AlgorithmBase.Management.ImagePreProcessing;
    using ColorMapTest.TestDataStructure.Management.ImagePreProcessing;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ImageLoadUnitTest : BaseImageLoad
    {
        [SetUp]
        public void Setup()
        {
            ExampleGenerator.Run();
        }


        [Test]
        [TestCaseSource("Images")]
        public void LoadImage(ImageLoadData input)
        {
            // Arrange
            ImageLoader.SetImagePath(String.Format("{0}{1}", Directory, input.ImageName));

            // Act
            var output = ImageLoader.Run();

            // Assert
            Assert.NotNull(output.PathToFile);
            Assert.NotNull(output.Raw);
            Assert.NotNull(output.RawTransfomed);

        }
    }
}
