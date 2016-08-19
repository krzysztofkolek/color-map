namespace ColorMapTest.BasicTest.AlgorithmBase.ColorAccordingToList
{
    using ColorMap.Algorithm.ColorAccordingToList;
    using System.Collections.Generic;
    using TestDataStructure.ColorAccordingToList;

    public class ColorAccordingToListAlgorithmBase
    {
        protected ColorAccordingToListAlgorithm Algorithm { get; set; }

        public ColorAccordingToListAlgorithmBase()
        {
            Algorithm = new ColorAccordingToListAlgorithm();
        }

        public static IEnumerable<ColorAccordingToListData> DataForColoring
        {
            get
            {
                yield return new ColorAccordingToListData()
                {
                    Input = new Dictionary<string, List<string>>()
                    {
                        { "A", new List<string>() { "B", "C", "D" } },
                        { "B", new List<string>() { "A", "D", "G", "H" } },
                        { "C", new List<string>() { "A", "D", "F" , "E" } },
                        { "D", new List<string>() { "A", "B", "G" , "F", "E", "C" } },
                        { "E", new List<string>() { "C", "D", "F", "G" } },
                        { "F", new List<string>() { "C", "D", "G", "E" } },
                        { "G", new List<string>() { "D", "B", "H", "E", "F" } },
                        { "H", new List<string>() { "B", "G" } },
                    },
                    Expected = new Dictionary<string, System.Drawing.Color>()
                    {
                        { "D", System.Drawing.Color.Yellow  },
                        { "G", System.Drawing.Color.Green   },
                        { "B", System.Drawing.Color.Red     },
                        { "C", System.Drawing.Color.Green   },
                        { "E", System.Drawing.Color.Red     },
                        { "F", System.Drawing.Color.Blue    },
                        { "A", System.Drawing.Color.Blue    },
                        { "H", System.Drawing.Color.Yellow  }
                    }
                };
            }
        }
    }
}
