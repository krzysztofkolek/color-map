
namespace ColorMapTest.TestDataStructure.Management.ImagePreProcessing
{
    using System.Drawing;

    public class ImageTransformData
    {
        public Image InputImage { get; set; }
        public byte[,] ExpectedOutput { get; set; }
    }
}
