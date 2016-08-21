namespace ColorMapTest.BasicTest.AlgorithmBase.CreateGraphFromArray
{
    using System.Collections.Generic;
    using ColorMap.Algorithm.CreateGraphFromArray;

    public class GraphFromArrayAlgorithmBase : BaseTest
    {
        protected GraphFromArrayAlgorithm GraphFromArrayAlgorithm { get; set; }

        public GraphFromArrayAlgorithmBase()
        {
            GraphFromArrayAlgorithm = new GraphFromArrayAlgorithm(Configuration);
        }
        public override void AdjustConfiguration()
        {

        }
        public static IEnumerable<TestDataStructure.GraphFromArray.GraphFromArrayData> CreateGraphFromArrayData
        {
            get
            {
                yield return new TestDataStructure.GraphFromArray.GraphFromArrayData()
                {
                    Input = ExampleGenerator.ExampleGenerator.FirstBlackWhiteStringPreColored,
                    InputPoints = ExampleGenerator.ExampleGenerator.FirstInputPoints,
                    Expected = ExampleGenerator.ExampleGenerator.FirstColoredMap
                };



                yield return new TestDataStructure.GraphFromArray.GraphFromArrayData()
                {
                    Input = ExampleGenerator.ExampleGenerator.SecondBlackWhiteStringPreColored,
                    InputPoints = ExampleGenerator.ExampleGenerator.SecondInputPoints,
                    Expected = ExampleGenerator.ExampleGenerator.SecondColoredMap
                };


                yield return new TestDataStructure.GraphFromArray.GraphFromArrayData()
                {
                    Input = ExampleGenerator.ExampleGenerator.ThirdBlackWhiteStringPreColored,
                    InputPoints = ExampleGenerator.ExampleGenerator.ThirdInputPoints,
                    Expected = ExampleGenerator.ExampleGenerator.ThirdColoredMap
                };

            }
        }
    }
}
