namespace ColorMap.DataStructure
{

    public class QueueFloodFillData
    {
        public byte[,] Image { get; set; }
        public QueueFloodFillDataPoint AlgorithmStartPoint { get; set; }
        public byte ReplacementColor { get; set; }
        public byte BorderColor { get; set; }
    }
}
