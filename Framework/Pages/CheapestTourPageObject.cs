using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    public class CheapestTourPageObject
    {
        IWebDriver _driver;

        public CheapestTourPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
        public void ScrollToReviews()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript($"window.scrollTo({0},{3000})");
        }
    }
}
