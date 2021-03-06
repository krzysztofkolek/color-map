﻿namespace ColorMap.DataStructure
{
    using ColorMap.DataStructure.Graph;
    using System.Collections.Generic;
    using System.Drawing;

    /// <summary>
    /// Output object for the whole process
    /// </summary>
    public class ProcessedImageData
    {
        public string Path { get; set; }
        public Image Image { get; set; }
        public byte[,] RawImage { get; set; }
        public byte[,] BlackWhiteImage { get; set; }
        public string[,] PreColoredImage { get; set; }
        public Dictionary<string, List<QueueFloodFillDataPoint>> LetterFilledRegions { get; set; }
        public Dictionary<string,List<string>> ListOfSiblingRegions { get; set; }
        public Dictionary<string, Color> ListOfLettersAndCorespondingColors { get; set; }
    }
}
