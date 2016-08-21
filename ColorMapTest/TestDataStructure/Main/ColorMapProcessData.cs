namespace ColorMapTest.TestDataStructure.Main
{
    using ColorMap.Configuration;
    using System.Collections.Generic;

    public class ColorMapProcessData
    {
        public string FileName { get; set; }
        public Dictionary<string, System.Drawing.Color> Expected { get; set; }
        public Config Configuration { get; set; }
    }
}
