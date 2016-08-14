namespace ColorMapTest.TestDataStructure.QueueFloodFill
{
    using System.Collections.Generic;

    public class QueueFloodFillData
    {
        public byte[,] BlackWhiteImage { get; set; }
        public List<QueueFloodFillDataPoint> PointToTest { get; set; }
        public QueueFloodFillDataPoint AlgorithmStartPoint { get; set; }
    }
}
