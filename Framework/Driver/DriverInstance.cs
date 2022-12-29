using OpenQA.Selenium;
using System;
using System.Diagnostics;
using OpenQA.Selenium.Edge;

namespace GitHubAutomation.Driver
{
    public class DriverInstance
    {
        private static IWebDriver _driver;

        public static IWebDriver GetInstance()
        {
            if (_driver == null)
            {
                _driver = new EdgeDriver();
                _driver.Navigate().GoToUrl("https://georgia4travel.ru/");
                _driver.Manage().Window.Maximize();
            }
            return _driver;
        }

        public static void CloseBrowser()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
