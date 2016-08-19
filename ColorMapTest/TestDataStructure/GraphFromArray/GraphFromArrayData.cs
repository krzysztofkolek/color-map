namespace ColorMapTest.TestDataStructure.GraphFromArray
{
    using ColorMap.DataStructure;
    using System;
    using System.Collections.Generic;

    public class GraphFromArrayData
    {
        public string[,] Input { get; set; }
        public Dictionary<string, List<QueueFloodFillDataPoint>> InputPoints { get; set; }
        public Dictionary<String, List<String>> Expected { get; set; }
    }
}
