namespace ColorMap.DataStructure.Graph
{
    using ColorMap.DataStructure.FloodFill;

    public class GraphFromArrayData
    {
        public QueueFloodFillData InputData { get; set; }
        public byte[,] BinaryArray { get; set; }

        public GraphFromArrayData(QueueFloodFillData input)
        {
            InputData = input;
        }
    }
}
