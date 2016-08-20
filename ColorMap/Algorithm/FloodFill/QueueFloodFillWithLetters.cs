namespace ColorMap.Algorithm.FloodFill
{
    using DataStructure;
    using DataStructure.FloodFill;
    using System.Collections.Generic; 
    using System.Linq;

    public class QueueFloodFillWithLetters : Algorithm
    {
        private QueueFloodFillWithLettersData _algorithmData { get; set; }
        private List<string> _alphabet = new List<string>();
        private List<string> _wholeAlphabet = new List<string>()
        {
             "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
        };
        private List<string> _userdAlphabet = new List<string>();
        private List<QueueFloodFillDataPoint> _taggedFields = new List<QueueFloodFillDataPoint>();
        private Queue<QueueFloodFillDataPoint> temp = new Queue<QueueFloodFillDataPoint>();
        private Queue<QueueFloodFillDataPoint> _filedToFill = new Queue<QueueFloodFillDataPoint>();
        private uint _failedCounter = 0;


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
            int y = _algorithmData.Image.GetLength(0),
                x = _algorithmData.Image.GetLength(1);

            _alphabet.Clear();
            _alphabet.AddRange(_wholeAlphabet);

            _data.LetterFilledRegions = new Dictionary<string, List<QueueFloodFillDataPoint>>();

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

                                _data.LetterFilledRegions.Add(letter, temp.ToList());
                            }
                        }
                    }
                }
            }

            return this;
        }


        private void FloodFillCheckIfEmpty(string[,] bmp, QueueFloodFillDataPoint pt, string targetLetter)
        {
            int height = bmp.GetLength(0),
                   width = bmp.GetLength(1);
            _filedToFill = new Queue<QueueFloodFillDataPoint>();
            _filedToFill.Enqueue(pt);

            int maxIterationCount = 350;
            while (_filedToFill.Count > 0 && _failedCounter < maxIterationCount)
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
    }
}
