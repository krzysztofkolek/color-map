
namespace ColorMapTest.BasicTest
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class BaseTest
    {
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
