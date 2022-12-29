using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    public class BatumiPageObject
    {
        IWebDriver _driver;

        public BatumiPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
        public void SortToursByPopularity()
        {
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div[1]/div/div/a[1]")).Click();
        }
        public FirstBatumiTourGuidePageObject GoToFirstBatumiTourPage()
        {
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/ul/li[1]")).Click();
            return new FirstBatumiTourGuidePageObject(_driver);
        }
    }
}
