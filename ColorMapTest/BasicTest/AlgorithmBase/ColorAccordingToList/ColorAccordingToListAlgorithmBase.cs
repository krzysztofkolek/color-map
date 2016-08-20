namespace ColorMapTest.BasicTest.AlgorithmBase.ColorAccordingToList
{
    using ColorMap.Algorithm.ColorAccordingToList;
    using System.Collections.Generic;
    using TestDataStructure.ColorAccordingToList;

    public class ColorAccordingToListAlgorithmBase : BaseTest
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

                yield return new ColorAccordingToListData()
                {
                    Input = new Dictionary<string, List<string>>()
                    {
                        { "A", new List<string>() { "H", "B" } },
                        { "B", new List<string>() { "C", "I" } },
                        { "C", new List<string>() { "B", "D", "I", "K", "K" } },
                        { "D", new List<string>() { "C", "K", "J", "L" } },
                        { "E", new List<string>() { "D", "F", "M", "L", "G" } },
                        { "F", new List<string>() { "G", "E", "M" } },
                        { "G", new List<string>() { "F", "M", "E", "T", "S" } },
                        { "H", new List<string>() { "A", "I", "B", "N", "O" } },
                        { "I", new List<string>() { "H", "B", "C", "O", "N", "P" } },
                        { "J", new List<string>() { "C", "K", "D", "P", "Q" } },
                        { "K", new List<string>() { "J", "D", "C", "L" } },
                        { "L", new List<string>() { "K", "D", "M", "E", "R", "Q", "S" } },
                        { "M", new List<string>() { "L", "E", "D", "G", "F", "S", "R", "T" } },
                        { "N", new List<string>() { "H", "O", "I", "V", "W" } },
                        { "O", new List<string>() { "N", "I", "H", "P", "U", "W", "V" } },
                        { "P", new List<string>() { "U", "O", "I", "J", "Q" } },
                        { "Q", new List<string>() { "P", "J", "R", "L", "X" } },
                        { "R", new List<string>() { "Q", "L", "S", "M" } },
                        { "S", new List<string>() { "R", "M", "L", "T", "G" } },
                        { "T", new List<string>() { "S", "G", "M" } },
                        { "U", new List<string>() { "P", "O", "W" } },
                        { "V", new List<string>() { "N", "W", "O" } },
                        { "W", new List<string>() { "V", "N", "O" } },
                        { "X", new List<string>() { "W", "V", "O", "N", "U" } }
                    },
                    Expected = new Dictionary<string, System.Drawing.Color>()
                    {
                        { "M", System.Drawing.Color.Yellow  },
                        { "L", System.Drawing.Color.Green   },
                        { "O", System.Drawing.Color.Yellow  },
                        { "I", System.Drawing.Color.Green   },
                        { "C", System.Drawing.Color.Yellow  },
                        { "E", System.Drawing.Color.Red     },
                        { "G", System.Drawing.Color.Green   },
                        { "H", System.Drawing.Color.Red     },
                        { "J", System.Drawing.Color.Green   },
                        { "N", System.Drawing.Color.Blue    },
                        { "P", System.Drawing.Color.Red     },
                        { "Q", System.Drawing.Color.Yellow  },
                        { "S", System.Drawing.Color.Red     },
                        { "X", System.Drawing.Color.Green   },
                        { "D", System.Drawing.Color.Red     },
                        { "K", System.Drawing.Color.Blue    },
                        { "R", System.Drawing.Color.Blue    },
                        { "F", System.Drawing.Color.Blue    },
                        { "T", System.Drawing.Color.Blue    },
                        { "U", System.Drawing.Color.Green   },
                        { "V", System.Drawing.Color.Green   },
                        { "W", System.Drawing.Color.Red     },
                        { "A", System.Drawing.Color.Yellow  },
                        { "B", System.Drawing.Color.Red     }
                    }
                };
            }
        }
    }
}
