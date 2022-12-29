using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    public class ForGuidePageObject
    {
        IWebDriver _driver;

        public ForGuidePageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public ForGuidePageObject OpenFormForGuides()
        {
            _driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div/button")).Click();
            return new ForGuidePageObject(_driver);
        }
    }
}
