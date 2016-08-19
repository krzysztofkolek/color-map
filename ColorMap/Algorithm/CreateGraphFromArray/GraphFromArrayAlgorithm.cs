namespace ColorMap.Algorithm.CreateGraphFromArray
{
    using ColorMap.DataStructure.Graph;
    using System;

     

    public class GraphFromArrayAlgorithm : Algorithm
    {
        private GraphData _inputData { get; set; }

        public GraphFromArrayAlgorithm()
        {
        }

        public GraphFromArrayAlgorithm(GraphData input)
        {
            _inputData = input;
        }

        public GraphFromArrayAlgorithm SetData(GraphData input)
        {
            _inputData = input;
            return this;
        }




        public override Algorithm Run()
        {

            return this;
        }
    }

}
