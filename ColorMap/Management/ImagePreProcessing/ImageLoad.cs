
namespace ColorMap.Management.ImagePreProcessing
{
    using ColorMap.DataStructure.Management.ImagePreProcessing;
    using Configuration;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;

    /// <summary>
    /// Loads image 
    /// </summary>
    public class ImageLoad : ImagePreProcessAction
    {
        private Config _config { get; set; }
        private string _imagePath { get; set; }

        public ImageLoad(Config configuration)
        {
            _config = configuration;
        }

        public ImageLoad SetImagePath(string path)
        {
            _imagePath = path;
            return this;
        }

        public override ImagePreProcessingData Run()
        {
            if (File.Exists(_imagePath))
            {
                Image loadedImage = new Bitmap(_imagePath);

                Bitmap bitmapImage = (loadedImage as Bitmap);
                int[,] rawImageIntValues = new int[bitmapImage.Height, bitmapImage.Width];
                for (int i = 0; i < bitmapImage.Height; i++)
                {
                    for (int j = 0; j < bitmapImage.Width; j++)
                    {
                        rawImageIntValues[i, j] = bitmapImage.GetPixel(j, i).ToArgb();
                    }
                }

                return new ImagePreProcessingData()
                {
                    PathToFile = _imagePath,
                    Raw = loadedImage,
                    RawTransfomed = rawImageIntValues
                };
            }

            return new ImagePreProcessingData();
        }
    }
}
