namespace ColorMap.Management.ImagePreProcessing
{
    using ColorMap.DataStructure;
    using System.Drawing;

    public class ImageSave
    {
        public void SaveChanges(ProcessedImageData _data, string pathWithFile)
        {
            Image loadedImage = new Bitmap(_data.Image);
            Bitmap bitmapImage = (loadedImage as Bitmap);
            for (int i = 0; i < bitmapImage.Height; i++)
            {
                for (int j = 0; j < bitmapImage.Width; j++)
                {
                    if (!_data.PreColoredImage[i, j].Equals("1"))
                    {
                        var letter = _data.PreColoredImage[i, j];
                        var color = _data.ListOfLettersAndCorespondingColors[letter];
                        bitmapImage.SetPixel(j, i, color);
                    }
                    else
                    {
                        bitmapImage.SetPixel(j, i, Color.Black);
                    }                   
                }
            }
            bitmapImage.Save(pathWithFile);
        }
    }
}
