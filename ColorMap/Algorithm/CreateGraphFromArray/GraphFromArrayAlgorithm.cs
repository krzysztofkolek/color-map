﻿namespace ColorMap.Algorithm.CreateGraphFromArray
{
    using ColorMap.DataStructure.Graph;
    using System;
    using System.Collections;

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

        private void CheckSurrounding(string[,] inputMatrix, int x, int y, string letter)
        {
            // Right
            CheckSurroundingHelper(inputMatrix, x + 1, y, letter);
            CheckSurroundingHelper(inputMatrix, x + 2, y, letter);

            // Down
            CheckSurroundingHelper(inputMatrix, x, y + 1, letter);
            CheckSurroundingHelper(inputMatrix, x, y + 2, letter);

            // Left
            CheckSurroundingHelper(inputMatrix, x - 1, y, letter);
            CheckSurroundingHelper(inputMatrix, x - 2, y, letter);

            // Up
            CheckSurroundingHelper(inputMatrix, x, y - 1, letter);
            CheckSurroundingHelper(inputMatrix, x, y - 2, letter);

            // Rigth Up
            CheckSurroundingHelper(inputMatrix, x + 1, y - 1, letter);
            CheckSurroundingHelper(inputMatrix, x + 2, y - 2, letter);

            // Left Up
            CheckSurroundingHelper(inputMatrix, x - 1, y - 1, letter);
            CheckSurroundingHelper(inputMatrix, x - 2, y - 2, letter);

            // Right Down
            CheckSurroundingHelper(inputMatrix, x + 1, y + 1, letter);
            CheckSurroundingHelper(inputMatrix, x + 2, y + 2, letter);

            // Left Down
            CheckSurroundingHelper(inputMatrix, x - 1, y + 1, letter);
            CheckSurroundingHelper(inputMatrix, x - 2, y + 2, letter);
        }

        private void CheckSurroundingHelper(string[,] inputMatrix, int x, int y, string letter)
        {
            int height = inputMatrix.GetLength(1),
                    width = inputMatrix.GetLength(0);

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
