using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;
namespace MVCAppTests.UITest.Common

{
    [TestClass]
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
           System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"../packages/Selenium.WebDriver.ChromeDriver.2.33.0/driver/win32/chromedriver.exe");
            // System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"c:/Software/selenium/chromedriver_win32/chromedriver.exe");
           driver = new ChromeDriver();
 

            ChromeOptions options = new ChromeOptions();

            //   options.BinaryLocation = "../packages/Selenium.WebDriver.ChromeDriver.2.33.0/driver/win32/chromedriver.exe";
            //  driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"),options.ToCapabilities(),TimeSpan.FromSeconds(600));  
           // driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), DesiredCapabilities.Chrome(),TimeSpan.FromSeconds(600));  


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
