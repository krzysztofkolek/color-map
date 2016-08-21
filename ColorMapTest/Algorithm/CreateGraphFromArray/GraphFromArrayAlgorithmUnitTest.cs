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
            GraphFromArrayAlgorithm.SetData(new ColorMap.DataStructure.Graph.GraphData()
            {
                InputMatrix = input.Input,
                InputPoints = input.InputPoints
            });
            var output = GraphFromArrayAlgorithm.Run().GetData().ListOfSiblingRegions;

            //Assert
            foreach (var expectedItem in input.Expected)
            {
                var outputList = output[expectedItem.Key];

                Assert.AreEqual(outputList.Count, expectedItem.Value.Count);

                foreach (var expectedListItem in expectedItem.Value)
                {
                    Assert.AreEqual(true, outputList.Contains(expectedListItem));
                }
            }
        }
    }
}
