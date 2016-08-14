
namespace ColorMapTest.Management.ImagePreProcessing
{
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
            ImageTransformAlgorithm.SetImage(input.InputImage);

            // Act
            var output = ImageTransformAlgorithm.Run().RawTransfomed;

            // Assert
            for (int i = 0; i < output.GetLength(1); i++)
            {
                for (int j = 0; j < output.GetLength(0); j++)
                {
                    Assert.AreEqual(input.ExpectedOutput[i, j], output[i, j]);
                }
            }
        }
    }
}
