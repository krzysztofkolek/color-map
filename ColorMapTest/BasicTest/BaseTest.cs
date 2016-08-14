
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
    }
}
