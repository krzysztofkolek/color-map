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

                yield return new QueueFloodFillWithLettersData()
                {
                    Input = ExampleGenerator.SecondBlackWhiteString,
                    Expected = new string[,]
                    {
                        {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1"   },
                        {"1","1","A","A","1","B","B","B","1","C","C","C","C","C","1","D","D","D","D","D","D","1","E","E","E","1","F","1","G","G","G","G","1"   },
                        {"1","A","1","1","1","B","B","B","1","C","C","C","C","C","1","D","D","D","D","D","D","1","E","E","E","1","F","1","G","G","G","G","1"   },
                        {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","G","G","G","G","1"   },
                        {"1","H","H","H","1","I","I","I","1","1","1","1","J","J","1","K","K","1","L","L","L","1","M","M","M","1","G","G","G","G","G","G","1"   },
                        {"1","H","H","H","1","I","I","I","1","1","1","1","J","J","1","1","1","1","1","L","L","1","M","M","M","1","G","G","G","G","G","G","1"   },
                        {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1"   },
                        {"1","N","N","N","1","O","O","O","1","P","P","P","P","P","1","Q","Q","Q","1","R","R","1","S","S","S","1","T","T","T","T","T","T","1"   },
                        {"1","N","N","N","1","O","O","O","1","1","1","1","1","1","1","Q","Q","Q","1","R","R","1","S","S","S","1","T","T","T","T","T","T","1"   },
                        {"1","1","1","1","1","1","1","1","1","U","U","U","U","1","1","1","1","1","1","R","R","1","S","S","S","1","T","T","T","T","T","T","1"   },
                        {"1","V","V","V","1","W","W","W","1","U","U","U","U","1","1","X","1","1","1","R","R","1","S","S","S","1","T","T","T","T","T","T","1"   },
                        {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1"   }
                    },
                    BorderColor = 1,
                    Image = ExampleGenerator.SecondBlackWhite
                };

            }
        }
    }
}