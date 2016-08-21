namespace ColorMapTest.BasicTest.AlgorithmBase.Management.ImagePreProcessing
{
    using ColorMap.Management.ImagePreProcessing;
    using ExampleGenerator;
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public class ImageSaveBase : BaseTest
    {
        protected ImageSave ImageSaver;
        protected ExampleGenerator ExampleGenerator { get; set; }
        private static List<string> _fileList { get; set; }
        private static List<string> _outputFileList { get; set; }

        static ImageSaveBase()
        {
            _fileList = new List<string>();
            _outputFileList = new List<string>();

            InvokeMethod<ImageSaveBase>("BaseSaveInit");

        }

        public ImageSaveBase()
        {
            ImageSaver = new ImageSave(Configuration);

            ExampleGenerator = new ExampleGenerator();
            ExampleGenerator.SetPath(Context.TestDirectory);
        }
        public void BaseSaveInit()
        {
            _fileList.Add(String.Format("{0}{1}", Directory, "ex1.bmp"));
            _fileList.Add(String.Format("{0}{1}", Directory, "ex2.bmp"));
            _fileList.Add(String.Format("{0}{1}", Directory, "pol.bmp"));
            _outputFileList.Add(String.Format("{0}{1}", Directory, "ex1_out.bmp"));
            _outputFileList.Add(String.Format("{0}{1}", Directory, "ex2_out.bmp"));
            _outputFileList.Add(String.Format("{0}{1}", Directory, "pol_out.bmp"));
        }

        public static IEnumerable<TestDataStructure.Management.ImagePreProcessing.ImageSaveData> SaveImageData
        {
            get
            {
                yield return new TestDataStructure.Management.ImagePreProcessing.ImageSaveData()
                {
                    Data = new ColorMap.DataStructure.ProcessedImageData()
                    {
                        Image = new Bitmap(_fileList[0]),
                        PreColoredImage = ExampleGenerator.FirstBlackWhiteStringPreColored,
                        ListOfLettersAndCorespondingColors = ExampleGenerator.FirstListOfLettersAndCorespondingColors
                    },
                    OutputFile = _outputFileList[0]
                };
                yield return new TestDataStructure.Management.ImagePreProcessing.ImageSaveData()
                {
                    Data = new ColorMap.DataStructure.ProcessedImageData()
                    {
                        Image = new Bitmap(_fileList[1]),
                        PreColoredImage = ExampleGenerator.SecondBlackWhiteStringPreColored,
                        ListOfLettersAndCorespondingColors = ExampleGenerator.SecondListOfLettersAndCorespondingColors
                    },
                    OutputFile = _outputFileList[1]
                };
                yield return new TestDataStructure.Management.ImagePreProcessing.ImageSaveData()
                {
                    Data = new ColorMap.DataStructure.ProcessedImageData()
                    {
                        Image = new Bitmap(_fileList[2]), 
                        PreColoredImage = ExampleGenerator.ThirdBlackWhiteStringPreColored, 
                        ListOfLettersAndCorespondingColors = ExampleGenerator.ThirdListOfLettersAndCorespondingColors
                    },
                    OutputFile = _outputFileList[2]
                };                
            }
        }

        public override void AdjustConfiguration()
        {

        }
    }
}
