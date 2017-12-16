﻿using MVCAppTests.UITest.Common;
using OpenQA.Selenium;
using System;

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
