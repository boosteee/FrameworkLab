using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    public class ForPartnerPageObject
    {
        IWebDriver _driver;

        public ForPartnerPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public ForPartnerFormPageObject OpenFormForPartners()
        {
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/a")).Click();
            return new ForPartnerFormPageObject(_driver);
        }

    }
}
