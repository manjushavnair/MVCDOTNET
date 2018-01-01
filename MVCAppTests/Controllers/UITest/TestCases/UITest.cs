using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCAppTests.UITest.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace MVCAppTests.UITest.TestCases

{


    [TestClass]
  // [TestFixture("chrome", "63", "Windows 10")]
    public class UITest
    {
      /*  private IWebDriver driver;
        private string browser;
        private string version;
        private string os;


           public UITest(String browser, String version, String os)
           {
               this.browser = browser;
               this.version = version;
               this.os = os;


           }

           public UITest()
           { 


           }*/


        [SetUp]
        public void Init()
        {
            
            Driver.Initialize();
        }

        //[TearDown]

        [TestCleanup]
        public void Cleanup()
        {
            Driver.driver.Close();
        }

    }
}
