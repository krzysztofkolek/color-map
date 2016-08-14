
namespace ColorMapTest.BasicTest.AlgorithmBase
{
    using ColorMap.Algorithm;
    using ColorMapTest.TestDataStructure;
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
                    _queueFloodFillAlgorithm = new QueueFloodFill();
                }
                return _queueFloodFillAlgorithm;
            }
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

                    },
                    AlgorithmStartPoints = new List<QueueFloodFillDataPoint>()
                    {
                    }
                };

                yield return new QueueFloodFillListData()
                {
                    BlackWhiteImage = ExampleGenerator.SecondBlackWhite,
                    PointsToTest = new List<QueueFloodFillDataPoint>()
                    {

                    },
                    AlgorithmStartPoints = new List<QueueFloodFillDataPoint>()
                    {
                    }
                };
            }
        }



    }
}
