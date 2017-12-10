﻿using NUnit.Framework; 
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
using System;
using System.Threading;
using MVCAppTests.UITest.Common;
using MVCAppTests.UITest.PageObjects;

namespace MVCAppTests.UITest.TestCases
{


    [TestClass]
    public class WUITest :UITest
    {
       
        [TestMethod]
 
        [Priority(1)]
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
 
        [Priority(2)]
        public void Can_Navigate_To_Login()


        {

            HomePage.home("Log in");
            Driver.driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

            Driver.driver.FindElement(By.Id("loginLink")).Click();


            Thread.Sleep(8000);

            Driver.driver.FindElement(By.Id("registerLink")).Click();

            LoginPage.register("Join Us"); 

            Thread.Sleep(8000);

            NUnit.Framework.Assert.AreEqual(LoginPage.Name, "Join Us");

 




        }

   

    }
}
