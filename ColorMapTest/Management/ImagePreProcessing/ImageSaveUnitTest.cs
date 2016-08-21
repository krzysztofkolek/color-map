namespace ColorMapTest.Management.ImagePreProcessing
{
    using ColorMapTest.BasicTest.AlgorithmBase.Management.ImagePreProcessing;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class ImageSaveUnitTest : ImageSaveBase
    {
        [Test]
        [TestCaseSource("SaveImageData")]
        public void SaveImage(TestDataStructure.Management.ImagePreProcessing.ImageSaveData input)
        {
            // A

            // Act 
            ImageSaver.SaveChanges(input.Data, input.OutputFile);

            // Assert
        }
    }
}
