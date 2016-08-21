
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
            })
            .SetConfiguration(inputTestObject.Configuration);
            QueueFloodFillAlgorithm.Run();

            Serialize(inputTestObject.Input, inputTestObject.FileName);

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
    }
}
