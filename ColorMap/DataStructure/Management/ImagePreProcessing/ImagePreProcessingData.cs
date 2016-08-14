
namespace ColorMap.DataStructure.Management.ImagePreProcessing
{
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    public class ImagePreProcessingData
    {
        public string PathToFile { get; set; }
        public Image Raw { get; set; }
        public int[,] RawTransfomed { get; set; }
    }
}
