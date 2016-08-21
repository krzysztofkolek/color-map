
namespace ColorMapTest.BasicTest
{
    using ColorMap.Configuration;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public abstract class BaseTest
    {
        private Config _config { get; set; }
        protected Config Configuration
        {
            get
            {
                return _config;
            }
            set
            {
                _config = value;
            }
        }

        public BaseTest()
        {
            CreateCleanConfiguration();
        }

        public void CreateCleanConfiguration()
        {

            Configuration = new Config()
            {
                QueueFloodFillWithLetter = new QueueFloodFillWithConfig(),
                ColorAccordingToListAlgorithm = new ColorAccordingToListAlgorithmConfig(),
                GraphFromArrayAlgorithm = new GraphFromArrayAlgorithmConfig(),
                ImageLoad = new ImageLoadConfig(),
                ImageSave = new ImageSaveConfig(),
                ImageTransform = new ImageTransformConfig(),
                QueueFloodFill = new QueueFloodFillConfig()
            };
        }

        public abstract void AdjustConfiguration();

        protected TestContext Context
        {
            get
            {
                return TestContext.CurrentContext;
            }
        }

        protected string Directory
        {
            get
            {
                return String.Format("{0}\\", Context.TestDirectory);
            }
        }

        public static void InvokeMethod<T>(string methodName)
            where T : class, new()
        {
            T invokedClass = new T();
            var method = invokedClass.GetType().GetMethod(methodName);
            method.Invoke(invokedClass, new object[] { });
        }
    }
}
