namespace ColorMapTest.BasicTest.AlgorithmBase.ColorAccordingToList
{
    using ColorMap.Algorithm.ColorAccordingToList;
    using System.Collections.Generic;
    using TestDataStructure.ColorAccordingToList;

    public class ColorAccordingToListAlgorithmBase
    {
        protected ColorAccordingToListAlgorithm ColorAccordingToListAlgorithm { get; set; }

        public ColorAccordingToListAlgorithmBase()
        {
            ColorAccordingToListAlgorithm = new ColorAccordingToListAlgorithm();
        }

        public static IEnumerable<ColorAccordingToListData> DataForColoring
        {
            get
            {
                yield return new ColorAccordingToListData();
            }
        }
    }
}
