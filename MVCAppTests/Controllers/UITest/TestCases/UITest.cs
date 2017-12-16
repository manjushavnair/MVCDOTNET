using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCAppTests.UITest.Common;

namespace MVCAppTests.UITest.TestCases
{

    [TestClass]
    public class UITest
    {

        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }

    }
}
