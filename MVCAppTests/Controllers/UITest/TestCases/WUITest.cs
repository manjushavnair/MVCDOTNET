using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCAppTests.UITest.Common;
using MVCAppTests.UITest.PageObjects;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MVCAppTests.UITest.TestCases
{


    [TestClass]
    public class WUITest :UITest
    {
       
        [TestMethod] 
        public void Can_Navigate_To_GoToHome()

        {

            HomePage.GoTo();

            System.Diagnostics.Debug.WriteLine(HomePage.Name);
            Console.WriteLine(HomePage.Name);
            Console.Write("MyPage.Name" + HomePage.Name);
            Driver.driver.Manage().Window.Maximize();

            HomePage.home("Log in");
            Driver.driver.FindElement(By.Id("loginLink")).Click();

            Thread.Sleep(2000); 
            NUnit.Framework.Assert.AreEqual(HomePage.Name, "Log in");
          
             
        }
       

        [TestMethod] 
        public void Can_Navigate_To_Login()


        {

            HomePage.home("Log in");
            Driver.driver.Manage().Window.Maximize();

            Thread.Sleep(3000);

            Driver.driver.FindElement(By.Id("loginLink")).Click();


            Thread.Sleep(4000);

            Driver.driver.FindElement(By.Id("registerLink")).Click();

           LoginPage.register("Register"); 

            Thread.Sleep(4000);

            NUnit.Framework.Assert.AreEqual(LoginPage.Name, "Register");

 




        }

   

    }
}
