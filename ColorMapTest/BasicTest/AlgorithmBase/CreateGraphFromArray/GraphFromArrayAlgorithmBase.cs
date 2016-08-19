﻿namespace ColorMapTest.BasicTest.AlgorithmBase.CreateGraphFromArray
{
    using ColorMap.DataStructure.Graph;
    using ColorMapTest.TestDataStructure.GraphFromArray;
    using System.Collections.Generic;
    using ExampleGenerator;

    public class GraphFromArrayAlgorithmBase : BaseTest
    {
        //protected Graph<byte> Algorithm { get; set; }

        public GraphFromArrayAlgorithmBase()
        {
            //Algorithm = new Graph<byte>();
        }

        public static IEnumerable<TestDataStructure.GraphFromArray.GraphFromArrayData> CreateGraphFromArrayData
        {
            get
            {
                yield return new TestDataStructure.GraphFromArray.GraphFromArrayData()
                {
                    
                    Input = ExampleGenerator.FirstBlackWhiteString,
                    Expected = new string[,]
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
                    }                    
                };
            }
        }
    }
}
