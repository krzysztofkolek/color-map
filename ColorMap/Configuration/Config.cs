namespace ColorMap.Configuration
{
    public class Config
    {
        public ImageLoadConfig ImageLoad { get; set; }
        public ImageTransformConfig ImageTransform { get; set; }
        public QueueFloodFillWithConfig QueueFloodFillWithLetter { get; set; }
        public ColorAccordingToListAlgorithmConfig ColorAccordingToListAlgorithm { get; set; }
        public GraphFromArrayAlgorithmConfig GraphFromArrayAlgorithm { get; set; }
        public ImageSaveConfig ImageSave { get; set; }
        public QueueFloodFillConfig QueueFloodFill { get; set; }
    }
}
