namespace ColorMapTest.Algorithm
{
    using ColorMapTest.BasicTest.AlgorithmBase;
    using ColorMapTest.TestDataStructure;
    using NUnit.Framework;

    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    public class QueueFloodFillUnitTest : QueueFloodFillBase
    {
        [Test]
        [TestCaseSource("DataFromStartingGenerator")]
        public void FillOneFiledFromStartingGenerator(QueueFloodFillData inputTestObject)
        {
            // Arrange
            byte testColor = 0x5;
            byte testBorder = 0x1;

            //Act 
            QueueFloodFillAlgorithm.SetData(new ColorMap.DataStructure.QueueFloodFillData()
            {
                Image = inputTestObject.BlackWhiteImage,
                AlgorithmStartPoint = new ColorMap.DataStructure.QueueFloodFillDataPoint()
                {
                    X = inputTestObject.AlgorithmStartPoint.X,
                    Y = inputTestObject.AlgorithmStartPoint.Y
                },
                ReplacementColor = testColor,
                BorderColor = testBorder
            });
            QueueFloodFillAlgorithm.Run();


            //Assert
            foreach (var pointForTest in inputTestObject.PointToTest)
            {
                Assert.AreEqual(testColor, inputTestObject.BlackWhiteImage[pointForTest.Y, pointForTest.X]);

            }
        }

        [Test]
        [TestCaseSource("DataFromGenerator")]
        public void FillOneFiledFromGenerator(QueueFloodFillData inputTestObject)
        {
            // Arrange
            byte testColor = 0x5;
            byte testBorder = 0x1;

            //Act 
            QueueFloodFillAlgorithm.SetData(new ColorMap.DataStructure.QueueFloodFillData()
            {
                Image = inputTestObject.BlackWhiteImage,
                AlgorithmStartPoint = new ColorMap.DataStructure.QueueFloodFillDataPoint()
                {
                    X = inputTestObject.AlgorithmStartPoint.X,
                    Y = inputTestObject.AlgorithmStartPoint.Y
                },
                ReplacementColor = testColor,
                BorderColor = testBorder
            });
            QueueFloodFillAlgorithm.Run();


            //Assert
            foreach (var pointForTest in inputTestObject.PointToTest)
            {
                Assert.AreEqual(testColor, inputTestObject.BlackWhiteImage[pointForTest.Y, pointForTest.X]);

            }
        }


        [Test]
        [TestCaseSource("DataListFromGenerator")]
        public void FillMultipleFiledsFromGenerator(QueueFloodFillListData inputTestObject)
        {
            // Arrange
            byte testColor = 0x5;

            //Act
            // start algoritm at those points 
            foreach (var startingPoint in inputTestObject.AlgorithmStartPoints)
            {
                QueueFloodFillAlgorithm.SetData(new ColorMap.DataStructure.QueueFloodFillData()
                {
                    Image = inputTestObject.BlackWhiteImage,
                    AlgorithmStartPoint = new ColorMap.DataStructure.QueueFloodFillDataPoint()
                    {
                        X = startingPoint.X,
                        Y = startingPoint.Y
                    },
                    ReplacementColor = testColor
                });

                QueueFloodFillAlgorithm.Run();
            }

            //Assert
            // chect all points for correct modifications
            foreach (var pointToTest in inputTestObject.PointsToTest)
            {
                Assert.AreEqual(testColor, inputTestObject.BlackWhiteImage[pointToTest.Y, pointToTest.X]);
            }
        }
    }
}
