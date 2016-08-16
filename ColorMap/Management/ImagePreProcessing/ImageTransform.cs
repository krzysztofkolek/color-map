
namespace ColorMap.Management.ImagePreProcessing
{
    using ColorMap.DataStructure.Management.ImagePreProcessing;
    using Emgu.CV;
    using Emgu.CV.Structure;
    using System.Drawing;

    /// <summary>
    /// Transforms image to a black and white image 
    /// </summary>
    public class ImageTransform : ImagePreProcessAction
    {
        private Image _data { get; set; }

        public ImageTransform SetImage(Image image)
        {
            _data = image;
            return this;
        }

        public override ImagePreProcessingData Run()
        {
            //var grayImage = new Image<Bgr, byte>(_data as Bitmap);
            Image<Gray, byte> grayFrame1 = new Image<Gray, byte>(new Size(1, 2));
            Image<Gray, byte> grayFrame = new Image<Gray, byte>(new Bitmap(@"D:\MyProjects\ColorMap\ColorMapTest\bin\Debug\ex2.bmp"));

            return null;
        }

    }
}
