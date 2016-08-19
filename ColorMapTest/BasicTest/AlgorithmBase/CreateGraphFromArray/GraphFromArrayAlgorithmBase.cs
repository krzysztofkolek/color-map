namespace ColorMapTest.BasicTest.AlgorithmBase.CreateGraphFromArray
{
    using System.Collections.Generic;
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
                    InputPoints = new Dictionary<string, List<ColorMap.DataStructure.QueueFloodFillDataPoint>>()
                    {
                         { "A", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1,1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2,1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(3,1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(4,1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(5,1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1,2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2,2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(3,2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(4,2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(5,2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1,3),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2,3),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(3,3),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(4,3),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(5,3)
                                } },
                         { "B", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(7,1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(8,1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9,1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(7,2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(8,2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9,2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(7,3),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(8,3),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9,3),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(7,4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(8,4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9,4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(7,5),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(8,5),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9,5)
                                } },
                         { "C", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1,5),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2,5)
                                } },
                         { "D", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(4,5),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(5,5)
                                } },
                         { "E", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1,7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2,7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1,8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2,8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1,9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2,9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(3,9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(4,9)
                                } },
                         { "F", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(4,7)
                                } },
                         { "G", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(6,7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(6,8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(6,9)
                                } },
                         { "H", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(8,7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9,7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(8,8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9,8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(8,9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9,9)
                                } }
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
