
namespace ColorMap.Management.ImagePreProcessing
{
    using ColorMap.DataStructure.Management.ImagePreProcessing;
    using Emgu.CV;
    using Emgu.CV.Structure;
    using System.Drawing;

    /// <summary>
    /// Transforms image to a black and white image 
    /// </summary>
    public class ImageTransform : ImagePreProcessAction
    {
        private ImagePreProcessingData _data { get; set; }

        public ImageTransform SetImage(ImagePreProcessingData input)
        {
            _data = input;
            return this;
        }

        public override ImagePreProcessingData Run()
        {
            CreateBlackAndWhite();
            RotateArray();

            return _data;
        }

        private void CreateBlackAndWhite()
        {
            Bitmap temp = _data.Raw as Bitmap;
            Image<Gray, byte> grayImage = new Image<Gray, byte>(temp);

            int y = temp.Height,
                x = temp.Width;

            _data.BlackAndWhite = new byte[y, x];

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    var actuallVal = ((byte[, ,])(grayImage.ManagedArray))[i, j, 0];
                    if (actuallVal.Equals(255))
                    {
                        _data.BlackAndWhite[i, j] = 0;
                    }
                    else if (actuallVal.Equals(0))
                    {
                        _data.BlackAndWhite[i, j] = 1;
                    }
                }
            }
        }

        private void RotateArray()
        {
            int xMax = _data.BlackAndWhite.GetLength(0),
                yMax = _data.BlackAndWhite.GetLength(0),
                xLast = _data.BlackAndWhite.GetLength(0) - 1;

            for (int y = 0; y < yMax; y++)
            {
                for (int x = 0; x < xMax; x++)
                {
                    if (xLast > x)
                    {
                        Swap(_data.BlackAndWhite, x, y, xLast, y);
                        xLast--;
                    }
                }
                xLast = _data.BlackAndWhite.GetLength(0) - 1;
            }

            int timesToRotate = 3;
            for (int i = 0; i < timesToRotate; i++)
            {
                _data.BlackAndWhite = RotateMatrixCounterClockwise<byte>(_data.BlackAndWhite);
            }

        }

        private T[,] RotateMatrixCounterClockwise<T>(T[,] oldMatrix)
        {
            T[,] newMatrix = new T[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];
            int newColumn, newRow = 0;
            for (int oldColumn = oldMatrix.GetLength(1) - 1; oldColumn >= 0; oldColumn--)
            {
                newColumn = 0;
                for (int oldRow = 0; oldRow < oldMatrix.GetLength(0); oldRow++)
                {
                    newMatrix[newRow, newColumn] = oldMatrix[oldRow, oldColumn];
                    newColumn++;
                }
                newRow++;
            }
            return newMatrix;
        }

        private void Swap<T>(T[,] matrix, int r1, int c1, int r2, int c2)
        {
            T temp = matrix[r1, c1];
            matrix[r1, c1] = matrix[r2, c2];
            matrix[r2, c2] = temp;
        }
    }
}
