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
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using MVCAppTests.UITest.Common;
using MVCAppTests.UITest.PageObjects;

namespace MVCAppTests.UITest.Common
{
 
    public class Driver
    {

        public static IWebDriver driver { get; set; }

        public static string BaseAddress
        {
            get
            {
                var url = "localhost";
                #if DEBUG
                    url = "localhost";
                #endif
                return url;
            }
        }

        public static void Initialize()
        {
            System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", @"/Software/selenium/geckodriver-v0.19.1-win64/geckodriver.exe");
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"/Software/selenium/chromedriver_win32/chromedriver.exe");
            driver = new ChromeDriver();
            TurnOnWait();
        }

        public static void Close()
        {
            driver.Close();
        }

        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
        }

        public static void NoWait(Action action)
        {
            TurnOffWait();
            action();
            TurnOnWait();
        }

        private static void TurnOnWait()
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1500);

        }

        private static void TurnOffWait()
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }
    
    }
}
