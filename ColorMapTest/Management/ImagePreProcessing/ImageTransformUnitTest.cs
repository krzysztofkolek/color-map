
namespace ColorMapTest.Management.ImagePreProcessing
{
    using ColorMap.DataStructure.Management.ImagePreProcessing;
    using ColorMapTest.BasicTest.AlgorithmBase.Management.ImagePreProcessing;
    using ColorMapTest.TestDataStructure.Management.ImagePreProcessing;
    using NUnit.Framework;

    [TestFixture]
    public class ImageTransformUnitTest : BaseImageTransform
    {
        [Test]
        [TestCaseSource("ImageTransformTestData")]
        public void TransformImage(ImageTransformData input)
        {
            // Arrange
            var inputToObject = new ImagePreProcessingData()
            {
                Raw = input.InputImage
            };
            ImageTransformAlgorithm.SetImage(inputToObject);

            // Act
            var output = ImageTransformAlgorithm.Run().BlackAndWhite;

            // Assert
            for (int i = 0; i < output.GetLength(0); i++)
            {
                for (int j = 0; j < output.GetLength(1); j++)
                {
                    Assert.AreEqual(input.ExpectedOutput[i, j], output[i, j]);
                }
            }
        }
    }
}
