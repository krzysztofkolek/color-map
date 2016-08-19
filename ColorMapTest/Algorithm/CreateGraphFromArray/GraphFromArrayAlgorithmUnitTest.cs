namespace ColorMapTest.Algorithm.CreateGraphFromArray
{
    using ColorMapTest.BasicTest.AlgorithmBase.CreateGraphFromArray;
    using NUnit.Framework;

    /// <summary>
    /// Graph creation 
    /// </summary>
    [TestFixture]
    public class GraphFromArrayAlgorithmUnitTest : GraphFromArrayAlgorithmBase
    {
        [Test]
        [TestCaseSource("CreateGraphFromArrayData")]
        public void CreateGraphFromArray(TestDataStructure.GraphFromArray.GraphFromArrayData input)
        {
            // Arrange


            //Act 
            //QueueFloodFillAlgorithm.SetData(new ColorMap.DataStructure.FloodFill.QueueFloodFillData()
            //{
            //    Image = inputTestObject.BlackWhiteImage,
            //    AlgorithmStartPoint = new ColorMap.DataStructure.QueueFloodFillDataPoint()
            //    {
            //        X = inputTestObject.AlgorithmStartPoint.X,
            //        Y = inputTestObject.AlgorithmStartPoint.Y
            //    },
            //    ReplacementColor = testColor,
            //    BorderColor = testBorder
            //});
            //QueueFloodFillAlgorithm.Run();


            //Assert
            //foreach (var pointForTest in inputTestObject.PointToTest)
            //{
            //    Assert.AreEqual(testColor, inputTestObject.BlackWhiteImage[pointForTest.Y, pointForTest.X]);

            //}

            Assert.NotNull(null);
        }
    }
}
