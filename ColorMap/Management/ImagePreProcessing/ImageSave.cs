namespace ColorMap.Management.ImagePreProcessing
{
    using ColorMap.DataStructure;
    using Configuration;
    using System.Drawing;

    public class ImageSave
    {
        private Config _config { get; set; }

        public ImageSave(Config configuration)
        {
            _config = configuration;
        }

        public void SaveChanges(ProcessedImageData _data, string pathWithFile)
        {
            Image loadedImage = _data.Image;
            Bitmap bitmapImage = (loadedImage as Bitmap);
            for (int i = 0; i < bitmapImage.Height; i++)
            {
                for (int j = 0; j < bitmapImage.Width; j++)
                {
                    if (!_data.PreColoredImage[j, i].Equals("1") && !_data.PreColoredImage[j, i].Equals("0"))
                    {
                        var letter = _data.PreColoredImage[j, i];
                        if (_data.ListOfLettersAndCorespondingColors.ContainsKey(letter))
                        {
                            var color = _data.ListOfLettersAndCorespondingColors[letter];
                            bitmapImage.SetPixel(j, i, color);
                        }
                        else
                        {
                            bitmapImage.SetPixel(j, i, Color.White);
                        }
                    }
                    else
                    {
                        bitmapImage.SetPixel(j,i, Color.Black);
                    }                   
                }
            }
            bitmapImage.Save(pathWithFile);
        }
    }
}
