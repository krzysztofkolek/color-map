
namespace ColorMapTest.BasicTest.AlgorithmBase.Management.ImagePreProcessing
{
    using ColorMap.Management.ImagePreProcessing;
    using ColorMapTest.TestDataStructure.Management.ImagePreProcessing;
    using ExampleGenerator;
    using System;
    using System.Collections.Generic;

    public class BaseImageTransform : BaseTest
    {
        protected ImageTransform ImageTransformAlgorithm { get; set; }

        private static ImageLoad _imageLoader { get; set; }
        private static List<string> _fileList { get; set; }
        static BaseImageTransform()
        {
            _imageLoader = new ImageLoad(new ColorMap.Configuration.Config());
            _fileList = new List<string>();

            InvokeMethod<BaseImageTransform>("BaseImageTransformInit");
        }

        public override void AdjustConfiguration()
        {

        }

        public BaseImageTransform()
        {
            ImageTransformAlgorithm = new ImageTransform(Configuration);
        }

        public void BaseImageTransformInit()
        {
            _fileList.Add(String.Format("{0}{1}", Directory, "ex1.bmp"));
            _fileList.Add(String.Format("{0}{1}", Directory, "ex2.bmp"));
            _fileList.Add(String.Format("{0}{1}", Directory, "pol.bmp"));
        }



        public static IEnumerable<ImageTransformData> ImageTransformTestData
        {
            get
            {
                yield return new ImageTransformData()
                {
                    InputImage = _imageLoader.SetImagePath(_fileList[0]).Run().Raw,
                    ExpectedOutput = ExampleGenerator.FirstBlackWhite
                };
                yield return new ImageTransformData()
                {
                    InputImage = _imageLoader.SetImagePath(_fileList[1]).Run().Raw,
                    ExpectedOutput = ExampleGenerator.SecondBlackWhite
                };
                yield return new ImageTransformData()
                {
                    InputImage = _imageLoader.SetImagePath(_fileList[2]).Run().Raw,
                    ExpectedOutput = ExampleGenerator.ThirdBlackWhite
                };
            }
        }
    }
}
