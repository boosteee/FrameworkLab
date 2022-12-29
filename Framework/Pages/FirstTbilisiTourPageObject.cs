using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    public class FirstTbilisiTourPageObject
    {
        IWebDriver _driver;

        public FirstTbilisiTourPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public SendMessagePageObject GoToSendMessagePage()
        {
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/aside/div[2]/div/div[4]/div[2]/a")).Click();
            return new SendMessagePageObject(_driver);
        }

        public FirstTbilisiTourPageObject BookATour()
        {
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div[2]/div[1]/div[1]/table/tbody/tr[5]/td[6]")).Click();
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div[2]/div[2]/div[2]/a")).Click();
            return new FirstTbilisiTourPageObject(_driver);
        }
    }
}
