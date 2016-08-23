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
                    _queueFloodFillAlgorithm = new QueueFloodFillWithLetters(Configuration);
                }
                return _queueFloodFillAlgorithm;
            }
        }
        public override void AdjustConfiguration()
        {
            
        }

        public static IEnumerable<QueueFloodFillWithLettersData> QueueFloodFillWithLetters
        {
            get
            {
                yield return new QueueFloodFillWithLettersData()
                {
                    Input = ExampleGenerator.FirstBlackWhiteString,
                    Expected = ExampleGenerator.FirstBlackWhiteStringPreColored,
                    BorderColor = 1,
                    Image = ExampleGenerator.FirstBlackWhite,
                    Configuration = new ColorMap.Configuration.Config()
                    {
                        QueueFloodFillWithLetter = new ColorMap.Configuration.QueueFloodFillWithConfig()
                        {
                            MaxIterationCount = 350,
                            Alphabet = ExampleGenerator.Alphabet
                        }
                    },
                    FileName = "First_"
                };

                yield return new QueueFloodFillWithLettersData()
                {
                    Input = ExampleGenerator.SecondBlackWhiteString,
                    Expected = ExampleGenerator.SecondBlackWhiteStringPreColored,
                    BorderColor = 1,
                    Image = ExampleGenerator.SecondBlackWhite,
                    Configuration = new ColorMap.Configuration.Config()
                    {
                        QueueFloodFillWithLetter = new ColorMap.Configuration.QueueFloodFillWithConfig()
                        {
                            MaxIterationCount = 350,
                            Alphabet = ExampleGenerator.Alphabet
                        }
                    },
                    FileName = "Second_"
                };

                yield return new QueueFloodFillWithLettersData()
                {
                    Input = ExampleGenerator.ThirdBlackWhiteString,
                    Expected = ExampleGenerator.ThirdBlackWhiteStringPreColored,
                    BorderColor = 1,
                    Image = ExampleGenerator.ThirdBlackWhite,
                    Configuration = new ColorMap.Configuration.Config()
                    {
                        QueueFloodFillWithLetter = new ColorMap.Configuration.QueueFloodFillWithConfig()
                        {
                            MaxIterationCount = 500000,
                            Alphabet = ExampleGenerator.Alphabet
                        }
                    },
                    FileName = "Third_"
                };

            }
        }
    }
}