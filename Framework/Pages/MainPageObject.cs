using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class MainPageObject
    {
        IWebDriver _driver;

        public MainPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public ForGuidePageObject GoToForGuidePage()
        {
            _driver.FindElement(By.XPath("/html/body/footer/div[1]/div/div[3]/nav/ul/li[1]/a")).Click();
            return new ForGuidePageObject(_driver);
        }

        public ForPartnerPageObject GoToForPartnerPage()
        {
            _driver.FindElement(By.XPath("/html/body/footer/div[1]/div/div[3]/nav/ul/li[2]/a")).Click();
            return new ForPartnerPageObject(_driver);
        }

        public AgreementsPageObject GoToAgreementsPage()
        {
            _driver.FindElement(By.XPath("/html/body/footer/div[1]/div/div[3]/nav/ul/li[4]/a")).Click();
            return new AgreementsPageObject(_driver);
        }

        public BatumiPageObject GoToBatumiPage()
        {
            _driver.FindElement(By.XPath("/html/body/header/div[2]/nav/ul/li[2]/a")).Click();
            return new BatumiPageObject(_driver);
        }

        public TbilisiPageObject GoToTbilisiPage()
        {
            _driver.FindElement(By.XPath("/html/body/header/div[2]/nav/ul/li[1]/a")).Click();
            return new TbilisiPageObject(_driver);
        }

        public AllToursPageObject GoToAllToursPage()
        {
            _driver.FindElement(By.XPath("/html/body/header/div[2]/nav/ul/li[8]/a")).Click();
            return new AllToursPageObject(_driver);
        }

        public BatumiPageObject SearchForIndividualBatumiTours()
        {
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/form/div[1]/div[1]/label[1]/div/a")).Click();
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/form/div[1]/div[1]/label[1]/div/div/ul/li[4]")).Click();
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/form/div[1]/div[1]/label[2]/div/a")).Click();
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/form/div[1]/div[1]/label[2]/div/div/ul/li[4]")).Click();
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/form/div[1]/div[1]/label[3]/div/a")).Click();
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/form/div[1]/div[1]/label[3]/div/div/ul/li[3]")).Click();
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/form/div[1]/div[2]/span[2]/a[1]")).Click();
            _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/form/div[2]/button")).Click();
            return new BatumiPageObject(_driver);
        }
    }
}
