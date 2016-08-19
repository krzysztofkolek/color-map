namespace ColorMap.DataStructure.Graph
{
    using System.Collections.Generic;

    public class GraphData
    {
        public string [,] InputMatrix { get; set; }
        public Dictionary<string, List<QueueFloodFillDataPoint>> InputPoints { get; set; }
    }
}
