using NUnit.Framework;
using MVCApp.Controllers;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace MVCApp.Controllers.Tests
{
   
    [TestClass]
    public class RegisterControllerTests
    {
        [TestMethod] 
        public void UserAddTest()
        {
            NUnit.Framework.Assert.Pass();
        }
    }
}