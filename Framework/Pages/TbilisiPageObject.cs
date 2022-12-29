using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    public class TbilisiPageObject
    {
        IWebDriver _driver;

        public TbilisiPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public PrometheusCavePageObject GoToPrometheusCavePage()
        {
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[2]/a[14]")).Click();
            return new PrometheusCavePageObject(_driver);
        }

        public FirstTbilisiTourPageObject GoToFirstTbilisiTourPage()
        {
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/ul/li[1]")).Click();
            return new FirstTbilisiTourPageObject(_driver);
        }
    }
}
