namespace ColorMap.Algorithm.FloodFill
{
    using ColorMap.DataStructure;
    using ColorMap.DataStructure.FloodFill;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class QueueFloodFillWithLetters : Algorithm
    {
        private QueueFloodFillWithLettersData _algorithmData { get; set; }
        private List<string> _alphabet = new List<string>()
        {
             "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
        };
        private List<string> _userdAlphabet = new List<string>();
        private List<QueueFloodFillDataPoint> _taggedFields = new List<QueueFloodFillDataPoint>();


        public QueueFloodFillWithLetters()
        {
        }

        public QueueFloodFillWithLetters SetData(QueueFloodFillWithLettersData input)
        {
            _algorithmData = input;
            return this;
        }

        public override Algorithm Run()
        {
            int y = _algorithmData.Image.GetLength(1),
                x = _algorithmData.Image.GetLength(0);

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    var element = _algorithmData.ImageForLetterFill[i, j];
                    if (!element.Equals(_algorithmData.BorderColor.ToString()) && !_alphabet.Contains(element) && !_userdAlphabet.Contains(element))
                    {
                        if (_alphabet.Count > 0)
                        {
                            var letter = _alphabet[0];
                            _userdAlphabet.Add(letter);
                            _alphabet.RemoveAt(0);
                            if (!_userdAlphabet.Contains(element))
                            {
                                Print();
                                FloodFill(_algorithmData.ImageForLetterFill, new QueueFloodFillDataPoint(j, i), letter);
                                Print();
                            }
                        }
                    }
                }
            }

            //_data.PreColoredImage = new string[y, x];
            //_data.PreColoredImage = _algorithmData.ImageForLetterFill;


           




            return this;
        }

        private void Print()
        {
            for (int iT = 0; iT < 11; iT++)
            {
                for (int jT = 0; jT < 11; jT++)
                {
                    Debug.Write(_algorithmData.ImageForLetterFill[iT, jT]);
                }
                Debug.Write("\n");
            }
            Debug.Write("\n");
        }

        bool ColorMatch(byte a, byte b)
        {
            return (a & 0xffffff) == (b & 0xffffff);
        }
        bool ColorMatch(string a, byte b)
        {
            return a.Equals(b.ToString());
        }
        bool ColorMatch(string a, string b)
        {
            return a.Equals(b);
        }

        private void FloodFill(string[,] bmp, QueueFloodFillDataPoint pt, string targetLetter)
        {
            int height = bmp.GetLength(1),
                width = bmp.GetLength(0);
            string targetColor = targetLetter;

            Queue<QueueFloodFillDataPoint> q = new Queue<QueueFloodFillDataPoint>();
            q.Enqueue(pt);

            while (q.Count > 0)
            {
                // Step 0
                QueueFloodFillDataPoint currentPixel = q.Dequeue();

                // Step 1
                // Color the current pixel 
                if (currentPixel.X < width && currentPixel.Y < height)
                {
                    if (!ColorMatch(bmp[currentPixel.X, currentPixel.Y], targetLetter))
                    {
                        if (!_userdAlphabet.Contains(bmp[currentPixel.X, currentPixel.Y]))
                        {
                            bmp[currentPixel.X, currentPixel.Y] = targetLetter;
                            _taggedFields.Add(new QueueFloodFillDataPoint()
                            {
                                X = currentPixel.X,
                                Y = currentPixel.Y
                            });
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                // Step 2 
                // Check surrounding pixels 
                //  Right
                bool rightCanContinue = true;
                for (int i = currentPixel.X; i < width; i++)
                {
                    if (i < width && currentPixel.Y < height)
                    {
                        if (ColorMatch(bmp[currentPixel.Y, i], _algorithmData.BorderColor))
                        {
                            rightCanContinue = false;
                        }

                        if (!ColorMatch(bmp[currentPixel.Y, i], _algorithmData.BorderColor))
                        {
                            if (!ColorMatch(bmp[currentPixel.Y, i], targetLetter))
                            {

                                if (rightCanContinue)
                                {
                                    var checkedValue = _taggedFields.Where(item => item.X == i && item.Y == currentPixel.Y).FirstOrDefault();
                                    if (checkedValue == null)
                                        q.Enqueue(new QueueFloodFillDataPoint(i, currentPixel.Y));
                                }
                            }
                        }
                    }
                }

                //  Down
                bool downCanContinue = true;
                for (int i = currentPixel.Y; i > 0 && i < height; i++)
                {
                    if (currentPixel.X < width && i < height)
                    {
                        if (ColorMatch(bmp[i, currentPixel.X], _algorithmData.BorderColor))
                        {
                            downCanContinue = false;
                        }

                        if (!ColorMatch(bmp[i, currentPixel.X], _algorithmData.BorderColor))
                        {
                            if (!ColorMatch(bmp[i, currentPixel.X], targetLetter))
                            {
                                if (downCanContinue)
                                {
                                    var checkedValue = _taggedFields.Where(item => item.X == currentPixel.X && item.Y == i).FirstOrDefault();
                                    if (checkedValue == null)
                                        q.Enqueue(new QueueFloodFillDataPoint(currentPixel.X, i));
                                }
                            }
                        }
                    }
                }

                //  Left
                bool leftCanContinue = true;
                for (int i = currentPixel.X; i > 0 && i < width; i--)
                {
                    if (i > 0 && i < width && currentPixel.Y < height)
                    {
                        if (ColorMatch(bmp[currentPixel.Y, i], _algorithmData.BorderColor))
                        {
                            leftCanContinue = false;
                        }

                        if (!ColorMatch(bmp[currentPixel.Y, i], _algorithmData.BorderColor))
                        {
                            if (!ColorMatch(bmp[currentPixel.Y, i], targetLetter))
                            {
                                if (leftCanContinue)
                                {
                                    var checkedValue = _taggedFields.Where(item => item.X == i && item.Y == currentPixel.Y).FirstOrDefault();
                                    if (checkedValue == null)
                                        q.Enqueue(new QueueFloodFillDataPoint(i, currentPixel.Y));
                                }
                            }
                        }
                    }
                }

                //  Up
                bool upCanContinue = true;
                for (int i = currentPixel.Y; i > 0 && i < height; i--)
                {
                    if (currentPixel.X < width && i < height)
                    {
                        if (ColorMatch(bmp[i, currentPixel.X], _algorithmData.BorderColor))
                        {
                            upCanContinue = false;
                        }

                        if (!ColorMatch(bmp[i, currentPixel.X], _algorithmData.BorderColor))
                        {
                            if (!ColorMatch(bmp[i, currentPixel.X], targetLetter))
                            {
                                if (upCanContinue)
                                {
                                    var checkedValue = _taggedFields.Where(item => item.Y == i && item.X == currentPixel.X).FirstOrDefault();
                                    if (checkedValue == null)
                                        q.Enqueue(new QueueFloodFillDataPoint(currentPixel.X, i));
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
