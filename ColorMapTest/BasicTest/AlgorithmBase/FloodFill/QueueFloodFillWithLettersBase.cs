namespace ColorMapTest.BasicTest.AlgorithmBase.FloodFill
{
    using ColorMap.Algorithm.FloodFill;
    using System.Collections.Generic;
    using ExampleGenerator;
    using TestDataStructure.QueueFloodFill;

    public class QueueFloodFillWithLettersBase : BaseTest
    {
        private QueueFloodFillWithLetters _queueFloodFillAlgorithm;
        protected QueueFloodFillWithLetters QueueFloodFillAlgorithm
        {
            get
            {
                if (_queueFloodFillAlgorithm == null)
                {
                    _queueFloodFillAlgorithm = new QueueFloodFillWithLetters();
                }
                return _queueFloodFillAlgorithm;
            }
        }

        public static IEnumerable<QueueFloodFillWithLettersData> QueueFloodFillWithLetters
        {
            get
            {
                yield return new QueueFloodFillWithLettersData()
                {
                    Input = ExampleGenerator.FirstBlackWhiteString,
                    Expected = new string[,]
                    {
                        {"1","1","1","1","1","1","1","1","1","1","1"},
                        {"1","A","A","A","A","A","1","B","B","B","1"},
                        {"1","A","A","A","A","A","1","B","B","B","1"},
                        {"1","A","A","A","A","A","1","B","B","B","1"},
                        {"1","1","1","1","1","1","1","B","B","B","1"},
                        {"1","C","C","1","D","D","1","B","B","B","1"},
                        {"1","1","1","1","1","1","1","1","1","1","1"},
                        {"1","E","E","1","F","1","G","1","H","H","1"},
                        {"1","E","E","1","1","1","G","1","H","H","1"},
                        {"1","E","E","E","E","1","G","1","H","H","1"},
                        {"1","1","1","1","1","1","1","1","1","1","1"}
                    },
                    BorderColor = 1,
                    Image = ExampleGenerator.FirstBlackWhite
                };
            }
        }
    }
}
