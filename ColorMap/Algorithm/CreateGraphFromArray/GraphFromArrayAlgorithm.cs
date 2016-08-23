namespace ColorMap.Algorithm.CreateGraphFromArray
{
    using ColorMap.DataStructure.Graph;
    using Configuration;

    public class GraphFromArrayAlgorithm : Algorithm
    {
        private Config _config { get; set; }

        private GraphData _inputData { get; set; }

        public GraphFromArrayAlgorithm(Config configuration)
        {
            _config = configuration;
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

        private void CheckSurrounding(string[,] inputMatrix, int x, int y, string letter)
        {
            int howManyNeighborPixelToVisit = _config.GraphFromArrayAlgorithm.HowManyNeighborPixelToVisit;

            for (int i = 0; i < howManyNeighborPixelToVisit; i++)
            {
                int stepValue = (i + 1);
                // Right
                CheckSurroundingHelper(inputMatrix, x + stepValue, y, letter);
                
                // Down
                CheckSurroundingHelper(inputMatrix, x, y + stepValue, letter);
                
                // Left
                CheckSurroundingHelper(inputMatrix, x - stepValue, y, letter);
                
                // Up
                CheckSurroundingHelper(inputMatrix, x, y - stepValue, letter);
                
                // Rigth Up
                CheckSurroundingHelper(inputMatrix, x + stepValue, y - stepValue, letter);
                
                // Left Up
                CheckSurroundingHelper(inputMatrix, x - stepValue, y - stepValue, letter);
                
                // Right Down
                CheckSurroundingHelper(inputMatrix, x + stepValue, y + stepValue, letter);
                
                // Left Down
                CheckSurroundingHelper(inputMatrix, x - stepValue, y + stepValue, letter);
            }
        }

        private void CheckSurroundingHelper(string[,] inputMatrix, int x, int y, string letter)
        {
            int height = inputMatrix.GetLength(0),
                    width = inputMatrix.GetLength(1);

            if (x < width && y < height && x >= 0 && y >= 0)
            {
                if (inputMatrix[y, x] != "1" && inputMatrix[y, x] != letter)
                {
                    if (_data.ListOfSiblingRegions == null)
                    {
                        _data.ListOfSiblingRegions = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>();
                    }

                    if (!_data.ListOfSiblingRegions.ContainsKey(letter))
                    {
                        _data.ListOfSiblingRegions.Add(letter, new System.Collections.Generic.List<string>());
                    }

                    if (!_data.ListOfSiblingRegions[letter].Contains(inputMatrix[y, x]))
                    {
                        _data.ListOfSiblingRegions[letter].Add(inputMatrix[y, x]);
                    }
                }
            }
        }

        public override Algorithm Run()
        {
            if (_data.ListOfSiblingRegions == null)
            {
                _data.ListOfSiblingRegions = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>();
            }

            if (_data.ListOfSiblingRegions.Count > 0)
            {
                _data.ListOfSiblingRegions = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>();
            }

            foreach (var dictionaryEntry in _inputData.InputPoints)
            {
                foreach (var inputPoint in dictionaryEntry.Value)
                {
                    CheckSurrounding(_inputData.InputMatrix, inputPoint.X, inputPoint.Y, dictionaryEntry.Key);
                }
            }

            return this;
        }
    }

}
