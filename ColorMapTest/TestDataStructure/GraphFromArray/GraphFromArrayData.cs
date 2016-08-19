namespace ColorMapTest.TestDataStructure.GraphFromArray
{
    using System;
    using System.Collections.Generic;

    public class GraphFromArrayData
    {
        public string[,] Input { get; set; }
        public Dictionary<String, List<String>> Expected { get; set; }
    }
}
