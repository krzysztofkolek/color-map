
namespace ColorMapTest.BasicTest
{
    using ColorMap.Configuration;
    using NUnit.Framework;
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

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
                QueueFloodFillWithLetter = new ColorMap.Configuration.QueueFloodFillWithConfig()
                {
                    MaxIterationCount = 500000,
                    Alphabet = ExampleGenerator.ExampleGenerator.Alphabet
                },
                ColorAccordingToListAlgorithm = new ColorMap.Configuration.ColorAccordingToListAlgorithmConfig()
                {
                    Colors = ExampleGenerator.ExampleGenerator.ColorsList

                },
                GraphFromArrayAlgorithm = new ColorMap.Configuration.GraphFromArrayAlgorithmConfig()
                {
                    HowManyNeighborPixelToVisit = 2
                },
                ImageLoad = new ColorMap.Configuration.ImageLoadConfig() { },
                ImageSave = new ColorMap.Configuration.ImageSaveConfig() { },
                ImageTransform = new ColorMap.Configuration.ImageTransformConfig() { },
                QueueFloodFill = new ColorMap.Configuration.QueueFloodFillConfig() { }
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

        public virtual String GetFileNameForSave()
        {
            return this.GetType().Name;
        }
        public virtual String GetFileNameWithDirectoryForSave(string caller)
        {
            return String.Format("{0}\\{1}{2}.txt", Directory, caller, GetFileNameForSave());
        }
        private void SaveToFile(String input, String callerName)
        {
            string filename = GetFileNameWithDirectoryForSave(callerName);
            using (StreamWriter w = File.AppendText(filename))
            {
                w.Write(String.Format("\r\n\r\n{0}\r\n", filename));
                w.Write(input);
            } 
        }

        protected void Serialize(string[,] t, string fileProcessed, [CallerMemberName]string memberName = "")
        {
            string output = "";

            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    output += t[i, j];
                }
                output += "\r\n";
            }

            SaveToFile(output, fileProcessed + memberName);
        }

        protected void Serialize(System.Collections.Generic.Dictionary<string, System.Drawing.Color> resultDic, string fileProcessed, [CallerMemberName]string memberName = "")
        {
            string output = "";
            foreach (var dictionaryEntry in resultDic)
            {
                output += "{ \"";
                output += System.String.Format("{0}", dictionaryEntry.Key);
                output += "\",  System.Drawing.Color.";
                output += System.String.Format("{0} ", dictionaryEntry.Value);
                output.Remove(output.Length - 1);

                output += "},\n ";
            }
            SaveToFile(output, fileProcessed + memberName);
        }

        protected void Serialize(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> resultDic, string fileProcessed, [CallerMemberName]string memberName = "")
        {
            string output = "";
            foreach (var dictionaryEntry in resultDic)
            {
                output += "{ \"";
                output += System.String.Format("{0}", dictionaryEntry.Key);
                output += "\",  new List<string>() { \n ";
                output += "\t";
                foreach (var dictionaryEntryValues in dictionaryEntry.Value)
                {
                    output += System.String.Format("\"{0}\", ", dictionaryEntryValues);
                }
                output.Remove(output.Length - 1);

                output += "\n },";
            }
            SaveToFile(output, fileProcessed + memberName);
        }
    }
}
