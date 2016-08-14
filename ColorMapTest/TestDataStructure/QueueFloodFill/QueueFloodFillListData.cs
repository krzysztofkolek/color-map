namespace ColorMapTest.TestDataStructure.QueueFloodFill
{
    using System.Collections.Generic;

    public class QueueFloodFillListData
    {
        public byte[,] BlackWhiteImage { get; set; }
        public List<QueueFloodFillDataPoint> PointsToTest { get; set; }
        public List<QueueFloodFillDataPoint> AlgorithmStartPoints { get; set; }
    }
}
