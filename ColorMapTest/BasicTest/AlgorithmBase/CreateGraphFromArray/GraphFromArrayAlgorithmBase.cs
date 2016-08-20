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



                yield return new TestDataStructure.GraphFromArray.GraphFromArrayData()
                {
                    Input = new string[,]
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
                    InputPoints = new Dictionary<string, List<ColorMap.DataStructure.QueueFloodFillDataPoint>>()
                    {
                         { "A", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1,   2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2,   1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(3,   1)
                                } },
                         { "B", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(6, 1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(7, 1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(8, 1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(6, 2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(7, 2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(8, 2)
                                } },
                         { "C", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9, 1) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(10, 1) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(11, 1) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(12, 1) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(13, 1) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9, 2) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(10, 2) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(11, 2) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(12, 2) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(13, 2)
                                } },
                         { "D", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(15,  1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(16,  1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(17,  1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(18,  1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(19,  1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(15,  2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(16,  2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(17,  2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(18,  2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(19,  2)
                                } },
                         { "E", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(22,  1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(23,  1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(24,  1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(22,  2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(23,  2),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(24,  2)
                                } },
                         { "F", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(26,  1),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(26,  2)
                                } },
                         { "G", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(28,  1) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(29,  1) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(30,  1) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(31,  1) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(28,  2) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(29,  2) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(30,  2) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(31,  2) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(28,  3) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(29,  3) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(30,  3) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(31,  3) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(26,  4) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(27,  4) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(28,  4) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(29,  4) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(30,  4) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(31,  4) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(26,  5) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(27,  5) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(28,  5) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(29,  5) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(30,  5) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(31,  5)
                                } },
                         { "H", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1, 4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2, 4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(3, 4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1, 5),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2, 5),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(3, 5)
                                } },
                         { "I", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(5, 4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(6, 4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(7, 4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(5, 5),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(6, 5),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(7, 5)
                                } },
                         { "J", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(12, 4) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(13, 4) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(12, 5) ,
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(13, 5)
                                } },
                         { "K", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(15, 4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(16,  4)
                                } },
                         { "L", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(18, 4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(19,  4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(20,  4),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(19,  5),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(20,  5)
                                } },
                         { "M", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                     new ColorMap.DataStructure.QueueFloodFillDataPoint(22, 4),
                                     new ColorMap.DataStructure.QueueFloodFillDataPoint(23,  4),
                                     new ColorMap.DataStructure.QueueFloodFillDataPoint(24,  4),
                                     new ColorMap.DataStructure.QueueFloodFillDataPoint(22,  5),
                                     new ColorMap.DataStructure.QueueFloodFillDataPoint(23,  5),
                                     new ColorMap.DataStructure.QueueFloodFillDataPoint(24,  5)
                                } },
                         { "N", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1, 7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2, 7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(3, 7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1, 8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2, 8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(3, 8)
                                } },
                         { "O", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(5,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(6, 7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(7, 7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(5, 8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(6, 8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(7, 8)

                                } },
                         { "P", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9   ,7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(10,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(11,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(12,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(13,  7)
                                } },
                         { "Q", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(15, 7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(16,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(17,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(15,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(16,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(17,  8)
                                } },
                         { "R", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(19, 7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(20,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(19,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(20,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(19,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(20,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(19,  10),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(20,  10)
                                } },
                         { "S", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(22, 7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(23,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(24,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(22,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(23,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(24,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(22,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(23,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(24,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(22,  10),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(23,  10),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(24,  10)
                                } },
                         { "T", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(26, 7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(27,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(28,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(29,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(30,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(31,  7),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(26,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(27,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(28,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(29,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(30,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(31,  8),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(26,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(27,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(28,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(29,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(30,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(31,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(26,  10   ),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(27,  10   ),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(28,  10   ),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(29,  10   ),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(30,  10   ),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(31,  10   )
                                } },
                         { "U", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(10,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(11,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(12,  9),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(9,   10),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(10,  10),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(11,  10),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(12,  10)
                                } },
                         { "V", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1, 10),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2, 10),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(3, 10)
                                } },
                         { "W", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(1, 10),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(2, 10),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(3, 10)
                                } },
                         { "X", new List<ColorMap.DataStructure.QueueFloodFillDataPoint>()
                                {
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(5, 10),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(6, 10),
                                    new ColorMap.DataStructure.QueueFloodFillDataPoint(7, 10)
                                } },
                    },
                    Expected = new Dictionary<string, List<string>>()
                    {
                        { "A", new List<string>() { "H", "B" } },
                        { "B", new List<string>() { "C", "I" } },
                        { "C", new List<string>() { "B", "D", "I", "K", "K" } },
                        { "D", new List<string>() { "C", "K", "J", "L" } },
                        { "E", new List<string>() { "D", "F", "M", "L", "G" } },
                        { "F", new List<string>() { "G", "E", "M" } },
                        { "G", new List<string>() { "F", "M", "E", "T", "S" } },
                        { "H", new List<string>() { "A", "I", "B", "N", "O" } },
                        { "I", new List<string>() { "H", "B", "C", "O", "N", "P" } },
                        { "J", new List<string>() { "C", "K", "D", "P", "Q" } },
                        { "K", new List<string>() { "J", "D", "C", "L" } },
                        { "L", new List<string>() { "K", "D", "M", "E", "R", "Q", "S" } },
                        { "M", new List<string>() { "L", "E", "D", "G", "F", "S", "R", "T" } },
                        { "N", new List<string>() { "H", "O", "I", "V", "W" } },
                        { "O", new List<string>() { "N", "I", "H", "P", "U", "W", "V" } },
                        { "P", new List<string>() { "U", "O", "I", "J", "Q" } },
                        { "Q", new List<string>() { "P", "J", "R", "L", "X" } },
                        { "R", new List<string>() { "Q", "L", "S", "M" } },
                        { "S", new List<string>() { "R", "M", "L", "T", "G" } },
                        { "T", new List<string>() { "S", "G", "M" } },
                        { "U", new List<string>() { "P", "O", "W" } },
                        { "V", new List<string>() { "N", "W", "O" } },
                        { "W", new List<string>() { "V", "N", "O" } },
                        { "X", new List<string>() { "W", "V", "O", "N", "U" } },
                    }
                };
            }
        }
    }
}
