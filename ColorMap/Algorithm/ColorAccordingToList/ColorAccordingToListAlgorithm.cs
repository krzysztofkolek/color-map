namespace ColorMap.Algorithm.ColorAccordingToList
{
    using DataStructure.ColorAccordingToList;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    public class ColorAccordingToListAlgorithm : Algorithm
    {
        private ColorAccordingToListData _inputData { get; set; }
        public ColorAccordingToListAlgorithm()
        {
            if (_data.ListOfLettersAndCorespondingColors == null)
            {
                _data.ListOfLettersAndCorespondingColors = new System.Collections.Generic.Dictionary<string, System.Drawing.Color>();
            }
        }

        public ColorAccordingToListAlgorithm(ColorAccordingToListData data)
        {
            if (_data.ListOfLettersAndCorespondingColors == null)
            {
                _data.ListOfLettersAndCorespondingColors = new System.Collections.Generic.Dictionary<string, System.Drawing.Color>();
            }

            _inputData = data;
        }

        public ColorAccordingToListAlgorithm SetData(ColorAccordingToListData input)
        {
            _inputData = input;
            return this;
        }
        
                

        public override Algorithm Run()
        {

            int counter = 0;
            Dictionary<string, int> result = new Dictionary<string, int>();
            List<Color> colors = new List<Color>()
            {
                Color.Yellow, 
                Color.Green, 
                Color.Red,
                Color.Blue
            };

            var sortedDictionary = (from entry in _inputData.Input
                                    orderby entry.Value.Count 
                                    descending
                                    select entry
                                    ).ToList();

            _inputData.Input = new Dictionary<string, List<string>>();

            foreach (var sortedItem in sortedDictionary)
            {
                _inputData.Input.Add(sortedItem.Key, sortedItem.Value);
            }
            
            foreach (var letterAndNeighbors in _inputData.Input)
            {
                if (counter == 0)
                {
                    result.Add(letterAndNeighbors.Key, 0);
                }

                if (counter++ > 0)
                {
                    var letter = letterAndNeighbors.Key;
                    var neighbors = letterAndNeighbors.Value;
                    List<int> colorsTemp = new List<int>() { 0, 1, 2, 3 };
                    int notAvailableColor = -1;

                    int howManyNeighbors = 0;
                    foreach (var item in neighbors)
                    {
                        if (result.ContainsKey(item))
                        {
                            var resultLetterValue = result[item];
                            var index = colorsTemp.IndexOf(resultLetterValue);

                            if (index != -1)
                            {
                                colorsTemp[index] = notAvailableColor;
                            }
                        }
                    }

                    var firstAvailableColor = colorsTemp.Where(availableColor => !availableColor.Equals(notAvailableColor)).First();

                    result.Add(letter, firstAvailableColor);
                }
            }

            _data.ListOfLettersAndCorespondingColors = new Dictionary<string, Color>();
            foreach (var resultItem in result)
            {
                _data.ListOfLettersAndCorespondingColors.Add(resultItem.Key, colors[resultItem.Value]);
            }

            return this;
        }
    }
}
