using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    public class FirstBatumiTourPageObject
    {
        IWebDriver _driver;
        public FirstBatumiTourPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public FirstBatumiTourGuidePageObject GoToGuidePage()
        {
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/aside/div[2]/div/div[1]")).Click();
            return new FirstBatumiTourGuidePageObject(_driver);
        }
    }
}
