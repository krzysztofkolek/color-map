using System.Collections.Generic;
using System.Drawing;

namespace ColorMapTest.TestDataStructure.ColorAccordingToList
{
    public class ColorAccordingToListData
    {
        public Dictionary<string, List<string>> Input { get; set; }
        public Dictionary<string, Color> Expected { get; set; }
    }
}
