
namespace ColorMap.DataStructure
{
    /// <summary>
    /// 
    /// </summary>
    public class ProcessedImageData
    {
        public string Path { get; set; }
        public byte[,] RawImage { get; set; }
        public byte[,] BlackWhiteImage { get; set; }
    }
}
