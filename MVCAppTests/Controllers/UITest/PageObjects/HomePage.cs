using NUnit.Framework;
using MVCApp.Controllers;
using System;
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

using System.Threading;
using MVCAppTests.UITest.Common;
using MVCAppTests.UITest.PageObjects;

namespace MVCAppTests.UITest.PageObjects
{
 
    public class HomePage
    {
        public static void GoTo()
        {
            Driver.driver.Navigate().GoToUrl("http://" + Driver.BaseAddress + "/MVCApp");
            
        }

        public static string Name
        {
            get
            {
                var title = Driver.driver.FindElement(By.Id("loginLink"));
                Console.WriteLine("title" + title);
     
                if (title != null)
                    return title.Text;
                return String.Empty;
            }
        }

        public static bool home(string name)
        {

            HomePage.GoTo();
            var bodyTag = Driver.driver.FindElement(By.Id("loginLink"));
       

            return bodyTag.Text.Contains(name);
        }
    }
}
