using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    public class ForPartnerFormPageObject
    {
        IWebDriver _driver;
        public ForPartnerFormPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
