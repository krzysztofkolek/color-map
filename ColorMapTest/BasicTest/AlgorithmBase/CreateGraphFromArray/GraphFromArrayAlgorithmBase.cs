namespace ColorMapTest.BasicTest.AlgorithmBase.CreateGraphFromArray
{
    using ColorMap.DataStructure.Graph;
    using ColorMapTest.TestDataStructure.GraphFromArray;
    using System.Collections.Generic;
    using ExampleGenerator;
    using ColorMap.Algorithm.CreateGraphFromArray;

    public class GraphFromArrayAlgorithmBase : BaseTest
    {
        protected GraphFromArrayAlgorithm GraphFromArrayAlgorithm { get; set; }

        public GraphFromArrayAlgorithmBase()
        {
            GraphFromArrayAlgorithm = new GraphFromArrayAlgorithm();
        }

        public static IEnumerable<TestDataStructure.GraphFromArray.GraphFromArrayData> CreateGraphFromArrayData
        {
            get
            {
                yield return new TestDataStructure.GraphFromArray.GraphFromArrayData()
                {
                    Input = new string[,]
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
                    Expected = new Dictionary<string, List<string>>()
                    {
                        { "A", new List<string>() { "B", "C", "D" } },
                        { "B", new List<string>() { "A", "D", "G", "H" } },
                        { "C", new List<string>() { "A", "D", "F" , "E" } },
                        { "D", new List<string>() { "A", "B", "G" , "F", "E", "C" } },
                        { "E", new List<string>() { "C", "D", "F", "G" } },
                        { "F", new List<string>() { "C", "D", "G", "E" } },
                        { "G", new List<string>() { "D", "B", "H", "E", "F" } },
                        { "H", new List<string>() { "B", "G" } },
                    }
                };
            }
        }
    }
}
