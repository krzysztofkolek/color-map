
namespace ColorMapTest.Algorithm.FloodFill
{
    using NUnit.Framework;
    using BasicTest.AlgorithmBase.FloodFill;
    using ColorMap.DataStructure.FloodFill;

    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    public class QueueFloodFillWithLettersUnitTest : QueueFloodFillWithLettersBase
    {
        [Test]
        [TestCaseSource("QueueFloodFillWithLetters")]
        public void QueueFloodFillWithLettersFillFromStartingGenerator(ColorMapTest.TestDataStructure.QueueFloodFill.QueueFloodFillWithLettersData inputTestObject)
        {
            // Arrange


            //Act 
            QueueFloodFillAlgorithm.SetData(new QueueFloodFillWithLettersData()
            {
                ImageForLetterFill = inputTestObject.Input,
                BorderColor = inputTestObject.BorderColor,
                Image = inputTestObject.Image,
                AlgorithmStartPoint = new ColorMap.DataStructure.QueueFloodFillDataPoint(0, 0)
            });
            QueueFloodFillAlgorithm.Run();
            Serialize(inputTestObject.Input, "D:\\letter1234.txt");

            //Assert
            int y = inputTestObject.Input.GetLength(0),
                x = inputTestObject.Input.GetLength(1);
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Assert.AreEqual(inputTestObject.Input[i, j], inputTestObject.Expected[i, j]);
                }
            }
        }
        public static void Serialize(string[,] t, string path)
        {
            using (System.IO.StreamWriter sr = new System.IO.StreamWriter(path))
            {
                for (int i = 0; i < t.GetLength(0); i++)
                {
                    for (int j = 0; j < t.GetLength(1); j++)
                    {
                        sr.Write("\",\"" + t[i, j]);
                    }
                    sr.Write("\r\n");
                }
            }
        }
    }
}
