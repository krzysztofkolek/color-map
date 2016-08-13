
namespace ColorMap
{
    public class ProcessedImageData
    {
        public string Path { get; set; }
        public int[,] ColorImage { get; set; }
        public byte[,] BlackWhiteImage { get; set; }
    }
}
