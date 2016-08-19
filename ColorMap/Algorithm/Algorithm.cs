
namespace ColorMap.Algorithm
{
    using ColorMap.DataStructure;

    /// <summary>
    /// 
    /// </summary>
    public abstract class Algorithm
    {
        protected ProcessedImageData _data { get; set; }

        public Algorithm()
        {
            _data = new ProcessedImageData();
            _data.LetterFilledRegions = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<QueueFloodFillDataPoint>>();
        }

        public virtual ProcessedImageData GetData()
        {
            return _data;
        }

        public abstract Algorithm Run();
    }
}
