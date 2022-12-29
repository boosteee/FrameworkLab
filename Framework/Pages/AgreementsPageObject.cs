using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    public class AgreementsPageObject
    {
        IWebDriver _driver;

        public AgreementsPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
