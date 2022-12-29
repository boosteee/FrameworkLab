using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    public class PrometheusCavePageObject
    {
        IWebDriver _driver;

        public PrometheusCavePageObject(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
