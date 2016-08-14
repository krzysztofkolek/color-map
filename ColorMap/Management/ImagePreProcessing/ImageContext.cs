
namespace ColorMap.Management.ImagePreProcessing
{
    using ColorMap.DataStructure.Management.ImagePreProcessing;

    /// <summary>
    /// 
    /// </summary>
    public class ImageContext
    {
        private ImagePreProcessAction _action { get; set; }

        public ImageContext(ImagePreProcessAction action)
        {

        }

        public ImagePreProcessingData Run()
        {
            return _action.Run();
        }
    }
}
