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
            Serialize(output, "D:\test.txt");

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

        
        public static void Serialize(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> resultDic, string path)
        {
            string output = "";
            foreach (var dictionaryEntry in resultDic)
            {
                output += "{ \"";
                output += System.String.Format("{0}", dictionaryEntry.Key);
                output += "\",  new List<string>() { \n ";
                output += "\t";
                foreach (var dictionaryEntryValues in dictionaryEntry.Value)
                {
                    output += System.String.Format("\"{0}\", ", dictionaryEntryValues);
                }
                output.Remove(output.Length - 1);

                output += "\n },";
            }


            
        }
    }
}
