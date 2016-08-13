
namespace ColorMap.Algorithm
{
    using ColorMap.DataStructure;

    /// <summary>
    /// 
    /// </summary>
    public abstract class Algorithm
    {
        private ProcessedImageData _data { get; set; }

        public virtual ProcessedImageData GetData()
        {
            return _data;
        }

        public abstract Algorithm Run();
    }
}
