
namespace ColorMapTest.BasicTest.AlgorithmBase
{
    using ColorMap.Algorithm;
    using ColorMapTest.TestDataStructure;
    using ExampleGenerator;
    using System.Collections.Generic;

    public class QueueFloodFillBase : BaseTest
    {
        private Algorithm _queueFloodFillAlgorithm;
        protected Algorithm QueueFloodFillAlgorithm
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


        public static IEnumerable<QueueFloodFillData> DataFromGenerator
        {
            get
            {
                yield return new QueueFloodFillData()
                {
                    BlackWhiteImage = ExampleGenerator.FirstBlackWhite,
                    PointsToTest = new List<QueueFloodFillDataPoint>()
                    {

                    }
                };

                yield return new QueueFloodFillData()
                {
                    BlackWhiteImage = ExampleGenerator.SecondBlackWhite,
                    PointsToTest = new List<QueueFloodFillDataPoint>()
                    {

                    }
                };
            }
        }
    }
}
