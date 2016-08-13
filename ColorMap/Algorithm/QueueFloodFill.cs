namespace ColorMap.Algorithm
{
    using ColorMap.DataStructure;
    using System.Collections.Generic;
    using System.Drawing;

    /// <summary>
    /// 
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
            byte targetColor = bmp[pt.X, pt.Y];

            Queue<QueueFloodFillDataPoint> q = new Queue<QueueFloodFillDataPoint>();
            q.Enqueue(pt);
            while (q.Count > 0)
            {
                QueueFloodFillDataPoint n = q.Dequeue();
                if (!ColorMatch(bmp[n.X, n.Y], targetColor))
                    continue;
                QueueFloodFillDataPoint w = n, e = new QueueFloodFillDataPoint(n.X + 1, n.Y);
                while ((w.X >= 0) && ColorMatch(bmp[w.X, w.Y], targetColor))
                {
                    bmp[w.X, w.Y] = replacementColor;
                    if ((w.Y > 0) && ColorMatch(bmp[w.X, w.Y - 1], targetColor))
                        q.Enqueue(new QueueFloodFillDataPoint(w.X, w.Y - 1));
                    if ((w.Y < height - 1) && ColorMatch(bmp[w.X, w.Y + 1], targetColor))
                        q.Enqueue(new QueueFloodFillDataPoint(w.X, w.Y + 1));
                    w.X--;
                }
                while ((e.X <= width - 1) && ColorMatch(bmp[e.X, e.Y], targetColor))
                {
                    bmp[e.X, e.Y] = replacementColor;
                    if ((e.Y > 0) && ColorMatch(bmp[e.X, e.Y - 1], targetColor))
                        q.Enqueue(new QueueFloodFillDataPoint(e.X, e.Y - 1));
                    if ((e.Y < height - 1) && ColorMatch(bmp[e.X, e.Y + 1], targetColor))
                        q.Enqueue(new QueueFloodFillDataPoint(e.X, e.Y + 1));
                    e.X++;
                }
            }
        }
    }
}
