namespace ColorMapTest.TestDataStructure
{
    using System.Collections.Generic;

    public class QueueFloodFillData
    {
        public byte[,] BlackWhiteImage { get; set; }
        public List<QueueFloodFillDataPoint> PointsToTest { get; set; }
        public List<QueueFloodFillDataPoint> AlgorithmStartPoints { get; set; }
    }
}
