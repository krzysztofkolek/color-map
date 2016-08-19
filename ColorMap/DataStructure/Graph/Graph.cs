namespace ColorMap.DataStructure.Graph
{
    using System;
    using System.Collections.Generic;
    using Algorithm;

    public class Graph : Algorithm
    {
        private byte[,] _input { get; set; }
        private string[,] matrix { get; set; }

        public Graph(byte[,] input)
        {
            _input = input;            
        }

        private void BuildMatrix()
        {
            int x = _input.GetLength(1),
                y = _input.GetLength(0);
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    matrix[i, j] = _input[i, j].ToString();
                }
            }
        }

        private void FillMatrixWithLetters()
        {

        }


        private void BuildAdjacencyMatrix()
        {

        }



        private void TemplateMethod()
        {
            BuildMatrix();
        }

        public override Algorithm Run()
        {

            TemplateMethod();
            return null;
        }
    }
}
