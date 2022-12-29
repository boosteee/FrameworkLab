using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    public class AllToursPageObject
    {
        IWebDriver _driver;

        public AllToursPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
        public void SortToursByPrice()
        {
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div[1]/div/div/a[3]")).Click();
        }
        public CheapestTourPageObject GoToCheapestTourPage()
        {
            _driver.Navigate().GoToUrl("https://georgia4travel.ru/excursion/eksklyuzivnye-i-unikalnye-ekskursii-tury-i-korporativy");
            return new CheapestTourPageObject(_driver);
        }
    }
}
