
namespace ColorMapTest.BasicTest.AlgorithmBase.FloodFill
{
    using ColorMap.Algorithm.FloodFill;
    using ColorMapTest.TestDataStructure;
    using ColorMapTest.TestDataStructure.QueueFloodFill;
    using ExampleGenerator;
    using System.Collections.Generic;

    public class QueueFloodFillBase : BaseTest
    {
        private QueueFloodFill _queueFloodFillAlgorithm;
        protected QueueFloodFill QueueFloodFillAlgorithm
        {
            get
            {
                if (_queueFloodFillAlgorithm == null)
                {
                    _queueFloodFillAlgorithm = new QueueFloodFill(Configuration);
                }
                return _queueFloodFillAlgorithm;
            }
        }
        public override void AdjustConfiguration()
        {

        }


        public static IEnumerable<QueueFloodFillData> DataFromStartingGenerator
        {
            get
            {
                yield return new QueueFloodFillData()
                {
                    BlackWhiteImage = ExampleGenerator.StartingBlackWhite,
                    PointToTest = new List<QueueFloodFillDataPoint>()
                    {
                        new QueueFloodFillDataPoint() { X = 1, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 3, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 1, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 3, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 1, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 3, Y = 3 }
                    },
                    AlgorithmStartPoint = new QueueFloodFillDataPoint()
                    {
                        X = 1,
                        Y = 1
                    }
                };
            }
        }

        public static IEnumerable<QueueFloodFillData> DataFromGenerator
        {
            get
            {
                yield return new QueueFloodFillData()
                {
                    BlackWhiteImage = ExampleGenerator.FirstBlackWhite,
                    PointToTest = new List<QueueFloodFillDataPoint>()
                    {
                        new QueueFloodFillDataPoint() { X = 1, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 3, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 4, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 5, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 1, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 3, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 4, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 5, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 1, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 1, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 3, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 4, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 5, Y = 3 }
                    },
                    AlgorithmStartPoint = new QueueFloodFillDataPoint()
                    {
                        X = 1,
                        Y = 1
                    }
                };
            }
        }


        public static IEnumerable<QueueFloodFillListData> DataListFromGenerator
        {
            get
            {
                yield return new QueueFloodFillListData()
                {
                    BlackWhiteImage = ExampleGenerator.FirstBlackWhite,
                    PointsToTest = new List<QueueFloodFillDataPoint>()
                    {
                        // Set 1
                        new QueueFloodFillDataPoint() { X = 1, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 3, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 4, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 5, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 1, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 3, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 4, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 5, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 1, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 3, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 4, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 5, Y = 3 },

                        // Set 2
                        new QueueFloodFillDataPoint() { X = 1, Y = 5 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 5 },

                        // Set 3
                        new QueueFloodFillDataPoint() { X = 1, Y = 7 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 7 },
                        new QueueFloodFillDataPoint() { X = 1, Y = 8 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 8 },
                        new QueueFloodFillDataPoint() { X = 1, Y = 9 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 9 },
                        new QueueFloodFillDataPoint() { X = 1, Y = 9 },
                        new QueueFloodFillDataPoint() { X = 2, Y = 9 },



                        // Set 4
                        new QueueFloodFillDataPoint() { X = 4, Y = 7 },



                        // Set 5
                        new QueueFloodFillDataPoint() { X = 6, Y = 7 },
                        new QueueFloodFillDataPoint() { X = 6, Y = 8 },
                        new QueueFloodFillDataPoint() { X = 6, Y = 9 },


                        // Set 6
                        new QueueFloodFillDataPoint() { X = 8, Y = 7 },
                        new QueueFloodFillDataPoint() { X = 9, Y = 7 },
                        new QueueFloodFillDataPoint() { X = 8, Y = 8 },
                        new QueueFloodFillDataPoint() { X = 9, Y = 8 },
                        new QueueFloodFillDataPoint() { X = 8, Y = 9 },
                        new QueueFloodFillDataPoint() { X = 9, Y = 9 },


                        // Set 7
                        new QueueFloodFillDataPoint() { X = 7, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 8, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 9, Y = 1 },
                        new QueueFloodFillDataPoint() { X = 7, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 8, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 9, Y = 2 },
                        new QueueFloodFillDataPoint() { X = 7, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 8, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 9, Y = 3 },
                        new QueueFloodFillDataPoint() { X = 7, Y = 4 },
                        new QueueFloodFillDataPoint() { X = 8, Y = 4 },
                        new QueueFloodFillDataPoint() { X = 9, Y = 4 },
                        new QueueFloodFillDataPoint() { X = 7, Y = 5 },
                        new QueueFloodFillDataPoint() { X = 8, Y = 5 },
                        new QueueFloodFillDataPoint() { X = 9, Y = 5 },


                    },
                    AlgorithmStartPoints = new List<QueueFloodFillDataPoint>()
                    {
                        // Set 1
                        new QueueFloodFillDataPoint()
                        {
                            X = 1,
                            Y = 1
                        },
                        // Set 2
                        new QueueFloodFillDataPoint()
                        {
                            X = 1,
                            Y = 5
                        },
                        // Set 3
                        new QueueFloodFillDataPoint()
                        {
                            X = 1,
                            Y = 7
                        },
                        // Set 4
                        new QueueFloodFillDataPoint()
                        {
                            X = 4,
                            Y = 7
                        },
                        // Set 5
                        new QueueFloodFillDataPoint()
                        {
                            X = 6,
                            Y = 7
                        },
                        // Set 6
                        new QueueFloodFillDataPoint()
                        {
                            X = 8,
                            Y = 7
                        },
                        // Set 7
                        new QueueFloodFillDataPoint()
                        {
                            X = 7,
                            Y = 1
                        }
                    }
                };
            }
        }



    }
}
