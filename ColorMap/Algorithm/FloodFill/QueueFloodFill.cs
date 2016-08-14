namespace ColorMap.Algorithm.FloodFill
{
    using ColorMap.DataStructure;
    using ColorMap.DataStructure.FloodFill;
    using System.Collections.Generic;

    /// <summary>
    /// Queue flood fill 
    /// </summary>
    public class QueueFloodFill : Algorithm
    {
        private QueueFloodFillData _algorithmData { get; set; }

        public QueueFloodFill()
        {
        }

        public QueueFloodFill SetData(QueueFloodFillData input)
        {
            _algorithmData = input;
            return this;
        }

        public override Algorithm Run()
        {
            FloodFill(_algorithmData.Image, _algorithmData.AlgorithmStartPoint, _algorithmData.ReplacementColor);
            return this;
        }

        bool ColorMatch(byte a, byte b)
        {
            return (a & 0xffffff) == (b & 0xffffff);
        }

        private void FloodFill(byte[,] bmp, QueueFloodFillDataPoint pt, byte replacementColor)
        {
            int height = bmp.GetLength(1),
                width = bmp.GetLength(0);
            byte targetColor = replacementColor;

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
                    if (!ColorMatch(bmp[currentPixel.X, currentPixel.Y], replacementColor))
                    {
                        bmp[currentPixel.X, currentPixel.Y] = replacementColor;
                    }
                    else
                    {
                        continue;
                    }
                }

                // Step 2 
                // Check surrounding pixels 
                //  Right
                for (int i = currentPixel.X; i < width; i++)
                {
                    if (i < width && currentPixel.Y < height)
                    {
                        if (!ColorMatch(bmp[i, currentPixel.Y], _algorithmData.BorderColor))
                        {
                            if (!ColorMatch(bmp[i, currentPixel.Y], replacementColor))
                            {
                                q.Enqueue(new QueueFloodFillDataPoint(i, currentPixel.Y));
                            }
                        }
                    }
                }

                //  Down
                for (int i = currentPixel.Y; i > 0 && i < height; i++)
                {
                    if (currentPixel.X < width && i < height)
                    {
                        if (!ColorMatch(bmp[currentPixel.X, i], _algorithmData.BorderColor))
                        {
                            if (!ColorMatch(bmp[currentPixel.X, i], replacementColor))
                            {
                                q.Enqueue(new QueueFloodFillDataPoint(currentPixel.X, i));
                            }
                        }
                    }
                }

                //  Left
                for (int i = currentPixel.X; i > 0 && i < width; i--)
                {
                    if (i > 0 && i < width && currentPixel.Y < height)
                    {
                        if (!ColorMatch(bmp[i, currentPixel.Y], _algorithmData.BorderColor))
                        {
                            if (!ColorMatch(bmp[i, currentPixel.Y], replacementColor))
                            {
                                q.Enqueue(new QueueFloodFillDataPoint(i, currentPixel.Y));
                            }
                        }
                    }
                }

                //  Up
                for (int i = currentPixel.Y; i > 0 && i < height; i--)
                {
                    if (currentPixel.X < width && i < height)
                    {
                        if (!ColorMatch(bmp[currentPixel.X, i], _algorithmData.BorderColor))
                        {
                            if (!ColorMatch(bmp[currentPixel.X, i], replacementColor))
                            {
                                q.Enqueue(new QueueFloodFillDataPoint(currentPixel.X, i));
                            }
                        }
                    }
                }
            }
        }
    }
}
