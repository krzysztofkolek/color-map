namespace ColorMapTest.BasicTest.Main
{
    using ColorMap;
    using ColorMapTest.TestDataStructure.Main;
    using System;
    using System.Collections.Generic;

    public class ColorMapProcessBase : BaseTest
    {
        protected ColorMapProcess MainProcess { get; set; }
        private static List<string> _fileList { get; set; }

        public ColorMapProcessBase()
        {
            MainProcess = new ColorMapProcess(Configuration);
        }
        public override void AdjustConfiguration()
        {

        }
        static ColorMapProcessBase()
        {
            _fileList = new List<string>();
            InvokeMethod<ColorMapProcessBase>("BaseImageTransformInit");
        }

        public void BaseImageTransformInit()
        {
            _fileList.Add(String.Format("{0}{1}", Directory, "ex1.bmp"));
            _fileList.Add(String.Format("{0}{1}", Directory, "ex2.bmp"));
            _fileList.Add(String.Format("{0}{1}", Directory, "pol.bmp"));
        }

        public static IEnumerable<ColorMapProcessData> ColorMapProcessData
        {
            get
            {
                yield return new ColorMapProcessData()
                {
                    FileName = _fileList[0],
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
                    },
                    Configuration = new ColorMap.Configuration.Config()
                    {
                        QueueFloodFillWithLetter = new ColorMap.Configuration.QueueFloodFillWithConfig()
                        {
                            MaxIterationCount = 350,
                            Alphabet = ExampleGenerator.ExampleGenerator.Alphabet
                        },
                        ColorAccordingToListAlgorithm = new ColorMap.Configuration.ColorAccordingToListAlgorithmConfig()
                        {
                            Colors = ExampleGenerator.ExampleGenerator.ColorsList
                        },
                        GraphFromArrayAlgorithm = new ColorMap.Configuration.GraphFromArrayAlgorithmConfig()
                        {
                            HowManyNeighborPixelToVisit = 2
                        },
                        ImageLoad = new ColorMap.Configuration.ImageLoadConfig(){ },
                        ImageSave = new ColorMap.Configuration.ImageSaveConfig() { },
                        ImageTransform = new ColorMap.Configuration.ImageTransformConfig() { },
                        QueueFloodFill = new ColorMap.Configuration.QueueFloodFillConfig() { }
                    }
                };
                yield return new ColorMapProcessData()
                {
                    FileName = _fileList[1],
                    Expected = new Dictionary<string, System.Drawing.Color>()
                    {
                        { "M", System.Drawing.Color.Yellow  },
                        { "L", System.Drawing.Color.Green   },
                        { "O", System.Drawing.Color.Yellow  },
                        { "I", System.Drawing.Color.Green   },
                        { "C", System.Drawing.Color.Yellow  },
                        { "E", System.Drawing.Color.Blue    },
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
                        { "F", System.Drawing.Color.Red     },
                        { "T", System.Drawing.Color.Blue    },
                        { "U", System.Drawing.Color.Blue    },
                        { "V", System.Drawing.Color.Red     },
                        { "W", System.Drawing.Color.Green   },
                        { "A", System.Drawing.Color.Yellow  },
                        { "B", System.Drawing.Color.Blue    }
                    },
                    Configuration = new ColorMap.Configuration.Config()
                    {
                        QueueFloodFillWithLetter = new ColorMap.Configuration.QueueFloodFillWithConfig()
                        {
                            MaxIterationCount = 350,
                            Alphabet = ExampleGenerator.ExampleGenerator.Alphabet
                        },
                        ColorAccordingToListAlgorithm = new ColorMap.Configuration.ColorAccordingToListAlgorithmConfig()
                        {
                            Colors = ExampleGenerator.ExampleGenerator.ColorsList

                        },
                        GraphFromArrayAlgorithm = new ColorMap.Configuration.GraphFromArrayAlgorithmConfig()
                        {
                            HowManyNeighborPixelToVisit = 2
                        },
                        ImageLoad = new ColorMap.Configuration.ImageLoadConfig() { },
                        ImageSave = new ColorMap.Configuration.ImageSaveConfig() { },
                        ImageTransform = new ColorMap.Configuration.ImageTransformConfig() { },
                        QueueFloodFill = new ColorMap.Configuration.QueueFloodFillConfig() { }
                    }
                };
                yield return new ColorMapProcessData()
                {
                    FileName = _fileList[2],
                    Expected = new Dictionary<string, System.Drawing.Color>()
                    {
                        { "O",  System.Drawing.Color.Yellow },
                        { "G",  System.Drawing.Color.Yellow },
                        { "L",  System.Drawing.Color.Green },
                        { "P",  System.Drawing.Color.Red },
                        { "A",  System.Drawing.Color.Green },
                        { "J",  System.Drawing.Color.Red },
                        { "C",  System.Drawing.Color.Red },
                        { "H",  System.Drawing.Color.Blue },
                        { "I",  System.Drawing.Color.Red },
                        { "K",  System.Drawing.Color.Yellow },
                        { "N",  System.Drawing.Color.Green },
                        { "T",  System.Drawing.Color.Green },
                        { "E",  System.Drawing.Color.Green },
                        { "M",  System.Drawing.Color.Green },
                        { "Q",  System.Drawing.Color.Blue },
                        { "R",  System.Drawing.Color.Yellow },
                        { "S",  System.Drawing.Color.Red },
                        { "U",  System.Drawing.Color.Blue },
                        { "B",  System.Drawing.Color.Yellow },
                        { "D",  System.Drawing.Color.Red },
                        { "F",  System.Drawing.Color.Yellow }
                    },
                    Configuration = new ColorMap.Configuration.Config()
                    {
                        QueueFloodFillWithLetter = new ColorMap.Configuration.QueueFloodFillWithConfig()
                        {
                            MaxIterationCount = 200000,
                            Alphabet = ExampleGenerator.ExampleGenerator.Alphabet
                        },
                        ColorAccordingToListAlgorithm = new ColorMap.Configuration.ColorAccordingToListAlgorithmConfig()
                        {
                            Colors = ExampleGenerator.ExampleGenerator.ColorsList

                        },
                        GraphFromArrayAlgorithm = new ColorMap.Configuration.GraphFromArrayAlgorithmConfig()
                        {
                            HowManyNeighborPixelToVisit = 2
                        },
                        ImageLoad = new ColorMap.Configuration.ImageLoadConfig() { },
                        ImageSave = new ColorMap.Configuration.ImageSaveConfig() { },
                        ImageTransform = new ColorMap.Configuration.ImageTransformConfig() { },
                        QueueFloodFill = new ColorMap.Configuration.QueueFloodFillConfig() { }
                    }
                };
            }
        }
    }
}
