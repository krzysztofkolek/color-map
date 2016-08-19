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
                                // Init
                                temp = new Queue<QueueFloodFillDataPoint>();
                                _filedToFill = new Queue<QueueFloodFillDataPoint>();
                                _failedCounter = 0;

                                // Get the filed to color
                                FloodFillCheckIfEmpty(_algorithmData.ImageForLetterFill, new QueueFloodFillDataPoint(j, i), "0");

                                // Color the filed 
                                foreach (var item in temp)
                                {
                                    _algorithmData.ImageForLetterFill[item.Y, item.X] = letter;
                                }                                
                            }
                        }
                    }
                }
            }

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

        Queue<QueueFloodFillDataPoint> temp = new Queue<QueueFloodFillDataPoint>();
        private Queue<QueueFloodFillDataPoint> _filedToFill = new Queue<QueueFloodFillDataPoint>();
        private void FloodFillCheckIfEmpty(string[,] bmp, QueueFloodFillDataPoint pt, string targetLetter)
        {
            int height = bmp.GetLength(1),
                   width = bmp.GetLength(0);
            _filedToFill = new Queue<QueueFloodFillDataPoint>();
            _filedToFill.Enqueue(pt);


            while (_filedToFill.Count > 0 && _failedCounter < 350)
            {
                QueueFloodFillDataPoint currentPixel = _filedToFill.Dequeue();


                if (currentPixel.X < width && currentPixel.Y < height)
                {
                    var value = bmp[currentPixel.Y, currentPixel.X];

                    if (value.Equals(targetLetter))
                    {
                        var isFirstItemPresentInQueue = _filedToFill.Where(queueItem => queueItem.X == pt.X && queueItem.Y == pt.Y).FirstOrDefault();
                        if (isFirstItemPresentInQueue == null)
                        {
                            _filedToFill.Enqueue(pt);
                        }

                        // Right
                        QueueFloodFillDataPoint pixel = new QueueFloodFillDataPoint()
                        {
                            X = currentPixel.X + 1,
                            Y = currentPixel.Y
                        };

                        if (CheckIfEmpty(bmp, pixel, targetLetter))
                        {
                            _filedToFill.Enqueue(pixel);
                        }

                        // Down
                        pixel = new QueueFloodFillDataPoint()
                        {
                            X = currentPixel.X,
                            Y = currentPixel.Y + 1
                        };

                        if (CheckIfEmpty(bmp, pixel, targetLetter))
                        {
                            _filedToFill.Enqueue(pixel);
                        }

                        // Right Down
                        pixel = new QueueFloodFillDataPoint()
                        {
                            X = currentPixel.X + 1,
                            Y = currentPixel.Y + 1
                        };

                        if (CheckIfEmpty(bmp, pixel, targetLetter))
                        {
                            _filedToFill.Enqueue(pixel);
                        }

                        // Left
                        pixel = new QueueFloodFillDataPoint()
                        {
                            X = currentPixel.X - 1,
                            Y = currentPixel.Y
                        };

                        // Left Down
                        pixel = new QueueFloodFillDataPoint()
                        {
                            X = currentPixel.X - 1,
                            Y = currentPixel.Y + 1
                        };

                        if (CheckIfEmpty(bmp, pixel, targetLetter))
                        {
                            _filedToFill.Enqueue(pixel);
                        }

                        if (CheckIfEmpty(bmp, pixel, targetLetter))
                        {
                            _filedToFill.Enqueue(pixel);
                        }

                        // Up
                        pixel = new QueueFloodFillDataPoint()
                        {
                            X = currentPixel.X,
                            Y = currentPixel.Y - 1
                        };

                        if (CheckIfEmpty(bmp, pixel, targetLetter))
                        {
                            _filedToFill.Enqueue(pixel);
                        }

                        // Right Up
                        pixel = new QueueFloodFillDataPoint()
                        {
                            X = currentPixel.X + 1,
                            Y = currentPixel.Y - 1
                        };

                        if (CheckIfEmpty(bmp, pixel, targetLetter))
                        {
                            _filedToFill.Enqueue(pixel);
                        }



                        // Left Up
                        pixel = new QueueFloodFillDataPoint()
                        {
                            X = currentPixel.X - 1,
                            Y = currentPixel.Y - 1
                        };

                        if (CheckIfEmpty(bmp, pixel, targetLetter))
                        {
                            _filedToFill.Enqueue(pixel);
                        }

                        foreach (var item in _filedToFill)
                        {
                            var isItemPresentInTempQueue = temp.Where(queueItem => queueItem.X == item.X && queueItem.Y == item.Y).FirstOrDefault();
                            if (isItemPresentInTempQueue == null)
                            {
                                temp.Enqueue(new QueueFloodFillDataPoint()
                                {
                                    X = item.X,
                                    Y = item.Y
                                });
                            }
                        }
                    }
                }
            }
        }

        private uint _failedCounter = 0;
        private bool CheckIfEmpty(string[,] bmp, QueueFloodFillDataPoint pt, string tagetLetter)
        {
            var contains = _filedToFill.Where(item => item.X == pt.X && item.Y == pt.Y).FirstOrDefault();
            if (bmp[pt.Y, pt.X].Equals(tagetLetter) && contains == null)
            {
                return true;
            }
            else
            {
                _failedCounter++;
                return false;
            }
        }

        private void FloodFill(string[,] bmp, QueueFloodFillDataPoint pt, string targetLetter)
        {
            int height = bmp.GetLength(1),
                width = bmp.GetLength(0);

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
                    if (!ColorMatch(bmp[currentPixel.Y, currentPixel.X], targetLetter))
                    {
                        if (!_userdAlphabet.Contains(bmp[currentPixel.Y, currentPixel.X]))
                        {
                            bmp[currentPixel.Y, currentPixel.X] = targetLetter;
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

                Print();

                bool downCanContinue = true;
                for (int i = currentPixel.X; i < width; i++)
                {
                    if (i < width && currentPixel.Y < height)
                    {
                        var elementValue = bmp[i, currentPixel.X];
                        if (ColorMatch(elementValue, _algorithmData.BorderColor))
                        {
                            downCanContinue = false;
                        }

                        var ifElementIsntBorder = !ColorMatch(elementValue, _algorithmData.BorderColor);
                        if (ifElementIsntBorder)
                        {
                            var ifValueIsntPainted = !ColorMatch(elementValue, targetLetter);
                            if (ifValueIsntPainted)
                            {
                                if (downCanContinue)
                                {

                                    q.Enqueue(new QueueFloodFillDataPoint(currentPixel.X, i));
                                }
                            }
                        }
                    }
                }

                //// Step 2 
                //// Check surrounding pixels 
                ////  Down
                bool rightCanContinue = true;
                for (int i = currentPixel.X; i < width; i++)
                {
                    if (i < width && currentPixel.Y < height)
                    {
                        var elementValue = bmp[currentPixel.Y, i];
                        if (ColorMatch(elementValue, _algorithmData.BorderColor))
                        {
                            rightCanContinue = false;
                        }

                        var ifElementIsntBorder = !ColorMatch(elementValue, _algorithmData.BorderColor);
                        if (ifElementIsntBorder)
                        {
                            var ifValueIsntPainted = !ColorMatch(elementValue, targetLetter);
                            if (ifValueIsntPainted)
                            {
                                if (rightCanContinue)
                                {
                                    q.Enqueue(new QueueFloodFillDataPoint(i, currentPixel.Y));
                                }
                            }
                        }
                    }
                }


                //bool rightCanContinue = true;
                //for (int i = currentPixel.X; i < width; i++)
                //{
                //    if (i < width && currentPixel.Y < height)
                //    {
                //        var elementValue = bmp[currentPixel.Y, i];
                //        if (ColorMatch(elementValue, _algorithmData.BorderColor))
                //        {
                //            rightCanContinue = false;
                //        }

                //        var ifElementIsntBorder = !ColorMatch(elementValue, _algorithmData.BorderColor);
                //        if (ifElementIsntBorder)
                //        {
                //            var ifValueIsntPainted = !ColorMatch(elementValue, targetLetter);
                //            if (ifValueIsntPainted)
                //            {
                //                if (rightCanContinue)
                //                {
                //                    q.Enqueue(new QueueFloodFillDataPoint(i, currentPixel.Y));
                //                }
                //            }
                //        }
                //    }
                //}







            }
        }
    }
}
