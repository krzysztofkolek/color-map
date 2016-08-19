namespace ColorMap.DataStructure
{
    using ColorMap.DataStructure.Graph;

    /// <summary>
    /// Output object for the whole process
    /// </summary>
    public class ProcessedImageData
    {
        public string Path { get; set; }
        public byte[,] RawImage { get; set; }
        public byte[,] BlackWhiteImage { get; set; }
        public string[,] PreColoredImage { get; set; }
    }
}
