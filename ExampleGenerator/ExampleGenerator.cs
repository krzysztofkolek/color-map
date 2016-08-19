﻿
namespace ExampleGenerator
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Class build for the purpuse of unit tests
    /// </summary>
    public class ExampleGenerator
    {
        private string _pathForimageExport { get; set; }

        public static byte[,] StartingBlackWhite
        {
            get
            {
                return new byte[,] 
                {
                    {0x1,0x1,0x1,0x1,0x1},
                    {0x1,0x0,0x0,0x0,0x1},
                    {0x1,0x0,0x0,0x0,0x1},
                    {0x1,0x0,0x0,0x0,0x1},
                    {0x1,0x1,0x1,0x1,0x1}
                };
            }
        }

        public static byte[,] FirstBlackWhite
        {
            get
            {
                return new byte[,]
                {
                    {0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1},
                    {0x1,0x0,0x0,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1},
                    {0x1,0x0,0x0,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1},
                    {0x1,0x0,0x0,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1},
                    {0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x0,0x0,0x0,0x1},
                    {0x1,0x0,0x0,0x1,0x0,0x0,0x1,0x0,0x0,0x0,0x1},
                    {0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1},
                    {0x1,0x0,0x0,0x1,0x0,0x1,0x0,0x1,0x0,0x0,0x1},
                    {0x1,0x0,0x0,0x1,0x1,0x1,0x0,0x1,0x0,0x0,0x1},
                    {0x1,0x0,0x0,0x0,0x0,0x1,0x0,0x1,0x0,0x0,0x1},
                    {0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1}
                };
            }
        }

        public static string[,] FirstBlackWhiteString
        {
            get
            {
                int y = FirstBlackWhite.GetLength(0), x = FirstBlackWhite.GetLength(1);
                string[,] temp = new string[y, x];

                temp = new string[,]{
                    { "1","1","1","1","1","1","1","1","1","1","1"},
                    { "1","0","0","0","0","0","1","0","0","0","1"},
                    { "1","0","0","0","0","0","1","0","0","0","1"},
                    { "1","0","0","0","0","0","1","0","0","0","1"},
                    { "1","1","1","1","1","1","1","0","0","0","1"},
                    { "1","0","0","1","0","0","1","0","0","0","1"},
                    { "1","1","1","1","1","1","1","1","1","1","1"},
                    { "1","0","0","1","0","1","0","1","0","0","1"},
                    { "1","0","0","1","1","1","0","1","0","0","1"},
                    { "1","0","0","0","0","1","0","1","0","0","1"},
                    { "1","1","1","1","1","1","1","1","1","1","1"}
                };
                
                return temp;
            }
        }

        public static byte[,] SecondBlackWhite
        {
            get
            {
                return new byte[,] 
                {
                    {0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,},
                    {0x1,0x1,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x1,0x0,0x0,0x0,0x0,0x1,},
                    {0x1,0x0,0x1,0x1,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x1,0x0,0x0,0x0,0x0,0x1,},
                    {0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x0,0x0,0x0,0x0,0x1,},
                    {0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x1,0x1,0x1,0x0,0x0,0x1,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x0,0x0,0x0,0x1,},
                    {0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x1,0x1,0x1,0x0,0x0,0x1,0x1,0x1,0x1,0x1,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x0,0x0,0x0,0x1,},
                    {0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,},
                    {0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x0,0x0,0x0,0x1,},
                    {0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x0,0x0,0x0,0x1,},
                    {0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x0,0x0,0x0,0x0,0x1,0x1,0x1,0x1,0x1,0x1,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x0,0x0,0x0,0x1,},
                    {0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x0,0x1,0x1,0x0,0x1,0x1,0x1,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x0,0x0,0x0,0x1,},
                    {0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,0x1,}
                };
            }
        }
        private string[,] _pixelValues = new string[,] 
        {
            {"1","1","1","1","1","1","1","1","1","1","1"},
            {"1","0","0","0","0","0","1","0","0","0","1"},
            {"1","0","0","0","0","0","1","0","0","0","1"},
            {"1","0","0","0","0","0","1","0","0","0","1"},
            {"1","1","1","1","1","1","1","0","0","0","1"},
            {"1","0","0","1","0","0","1","0","0","0","1"},
            {"1","1","1","1","1","1","1","1","1","1","1"},
            {"1","0","0","1","0","1","0","1","0","0","1"},
            {"1","0","0","1","1","1","0","1","0","0","1"},
            {"1","0","0","0","0","1","0","1","0","0","1"},
            {"1","1","1","1","1","1","1","1","1","1","1"}
        };
        private string[,] _pixelValues1 = new string[,] 
        {
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","0","0","1","0","0","0","1","0","0","0","0","0","1","0","0","0","0","0","0","1","0","0","0","1","0","1","0","0","0","0","1",},
            {"1","0","1","1","1","0","0","0","1","0","0","0","0","0","1","0","0","0","0","0","0","1","0","0","0","1","0","1","0","0","0","0","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","0","0","0","1",},
            {"1","0","0","0","1","0","0","0","1","1","1","1","0","0","1","0","0","1","0","0","0","1","0","0","0","1","0","0","0","0","0","0","1",},
            {"1","0","0","0","1","0","0","0","1","1","1","1","0","0","1","1","1","1","1","0","0","1","0","0","0","1","0","0","0","0","0","0","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","0","0","0","1","0","0","0","1","0","0","0","0","0","1","0","0","0","1","0","0","1","0","0","0","1","0","0","0","0","0","0","1",},
            {"1","0","0","0","1","0","0","0","1","1","1","1","1","1","1","0","0","0","1","0","0","1","0","0","0","1","0","0","0","0","0","0","1",},
            {"1","1","1","1","1","1","1","1","1","0","0","0","0","1","1","1","1","1","1","0","0","1","0","0","0","1","0","0","0","0","0","0","1",},
            {"1","0","0","0","1","0","0","0","1","0","0","0","0","1","1","0","1","1","1","0","0","1","0","0","0","1","0","0","0","0","0","0","1",},
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",}
        };

        public ExampleGenerator SetPath(string path)
        {
            _pathForimageExport = path;
            return this;
        }

        /// <summary>
        /// Simple method for test 
        /// Method is shouldbe surrounded by a try/catch blok 
        /// </summary>
        public void Run()
        {
            try
            {
                int x = _pixelValues.GetUpperBound(0) + 1;
                int y = _pixelValues.GetUpperBound(1) + 1;

                Bitmap bmp = new Bitmap(x, y);
                using (Graphics graph = Graphics.FromImage(bmp))
                {
                    Rectangle ImageSize = new Rectangle(0, 0, x, y);
                    graph.FillRectangle(Brushes.White, ImageSize);
                }

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (_pixelValues[i, j] == "1")
                            bmp.SetPixel(i, j, Color.Black);
                        else
                            bmp.SetPixel(i, j, Color.White);
                    }
                }

                bmp.Save(String.Format("{0}\\ex1.bmp", _pathForimageExport));

                x = _pixelValues1.GetUpperBound(0) + 1;
                y = _pixelValues1.GetUpperBound(1) + 1;

                bmp = new Bitmap(x, y);
                using (Graphics graph = Graphics.FromImage(bmp))
                {
                    Rectangle ImageSize = new Rectangle(0, 0, x, y);
                    graph.FillRectangle(Brushes.White, ImageSize);
                }

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (_pixelValues1[i, j] == "1")
                            bmp.SetPixel(i, j, Color.Black);
                        else
                            bmp.SetPixel(i, j, Color.White);
                    }
                }

                bmp.Save(String.Format("{0}\\ex2.bmp", _pathForimageExport));
            }
            catch (Exception ex)
            {
            }
        }
    }
}
