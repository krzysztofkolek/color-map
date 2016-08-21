namespace ColorMapTest.TestDataStructure.QueueFloodFill
{
    using ColorMap.Configuration;

    public class QueueFloodFillWithLettersData
    {
        public byte[,] Image { get; set; }
        public string[,] Input { get; set; }
        public byte BorderColor { get; set; }
        public string[,] Expected { get; set; }
        public Config Configuration { get; set; }
        public string FileName { get; set; }
    }
}
