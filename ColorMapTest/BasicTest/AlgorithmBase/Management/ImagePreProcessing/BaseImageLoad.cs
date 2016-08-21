
namespace ColorMapTest.BasicTest.AlgorithmBase.Management.ImagePreProcessing
{
    using ColorMap.Management.ImagePreProcessing;
    using ColorMapTest.TestDataStructure.Management.ImagePreProcessing;
    using ExampleGenerator;
    using System.Collections.Generic;
    using System;

    public class BaseImageLoad : BaseTest
    {
        protected ImageLoad ImageLoader;
        protected ExampleGenerator ExampleGenerator { get; set; }

        public BaseImageLoad()
        {
            ImageLoader = new ImageLoad(Configuration);

            ExampleGenerator = new ExampleGenerator();
            ExampleGenerator.SetPath(Context.TestDirectory);
        }


        public static IEnumerable<ImageLoadData> Images
        {
            get
            {
                yield return new ImageLoadData()
                {
                    ImageName = "ex1.bmp"
                };
                yield return new ImageLoadData()
                {
                    ImageName = "ex2.bmp"
                };
                yield return new ImageLoadData()
                {
                    ImageName = "pol.bmp"
                };
            }
        }

        public override void AdjustConfiguration()
        {
            
        }
    }
}
