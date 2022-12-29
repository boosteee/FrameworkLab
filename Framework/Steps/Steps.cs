using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GitHubAutomation.Steps
{
    public class Steps
    {
        IWebDriver _driver;

        IWebElement _searchForCountry => _driver.FindElement(By.XPath("/html/body/div[1]/sherpa-apps-root/sherpa-apps-map-container/header/nav/sherpa-apps-map-filter/form/div/div[3]/search-ui-destination-search/span/span/sherpa-apps-filter-chip/button/span[1]/div"));


        public void InitBrowser()
        {
            _driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }
        
        public void OpenBatumiPage()
        {
            Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
            mainPage.GoToBatumiPage();
        }

        public void SortBatumiToursByPopularity() 
        {
            Pages.BatumiPageObject batumiPage = new Pages.BatumiPageObject(_driver);
            batumiPage.SortToursByPopularity();
        }

        public void SearchForBatumiIndividualTours()
        {
            Pages.MainPageObject mainPage = new Pages.MainPageObject( _driver);
            mainPage.SearchForIndividualBatumiTours();
        }
        
        public void OpenTbilisiPage()
        {
            Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
            mainPage.GoToTbilisiPage();
        }

        public void OpenPrometheusCavePage()
        {
            Pages.TbilisiPageObject tbilisiPage = new Pages.TbilisiPageObject(_driver);
            tbilisiPage.GoToPrometheusCavePage();
        }

        public void OpenAllToursPage()
        {
            Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
            mainPage.GoToAllToursPage();
        }

        public void SearchForTheCheapestTour()
        {
            Pages.AllToursPageObject allToursPage = new Pages.AllToursPageObject(_driver);
            allToursPage.SortToursByPrice();
        }

        public void OpenTheCheapestTourPage()
        {
            Pages.AllToursPageObject allToursPage = new Pages.AllToursPageObject( _driver);
            allToursPage.GoToCheapestTourPage();
        }
        public void ScrollToCheapestTourReviews()
        {
            Pages.CheapestTourPageObject cheapestTourPage = new Pages.CheapestTourPageObject(_driver);
            cheapestTourPage.ScrollToReviews();
        }
        public void OpenUserAgreements()
        {
            Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
            mainPage.GoToAgreementsPage();
        }
        
        public void OpenTbilisiFirstTourPage()
        {
            Pages.TbilisiPageObject tbilisiPage = new Pages.TbilisiPageObject(_driver);
            tbilisiPage.GoToFirstTbilisiTourPage();
        }

        public void OpenSendMessagePage()
        {
            Pages.FirstTbilisiTourPageObject firstTbilisiTourPage = new Pages.FirstTbilisiTourPageObject( _driver);
            firstTbilisiTourPage.GoToSendMessagePage();
        }

        public void BookAFirstTbilisiTour()
        {
            Pages.FirstTbilisiTourPageObject firstTbilisiTourPage = new Pages.FirstTbilisiTourPageObject(_driver);
            firstTbilisiTourPage.BookATour();
        }

        public void OpenBatumiFirstTourPage()
        {
            Pages.BatumiPageObject batumiPage = new Pages.BatumiPageObject(_driver);
            batumiPage.GoToFirstBatumiTourPage();
        }

        public void OpenBatumiFirstTourGuidePage()
        {
            Pages.FirstBatumiTourPageObject firstBatumiTourPage = new Pages.FirstBatumiTourPageObject(_driver);
            firstBatumiTourPage.GoToGuidePage();
        }

        public void OpenForGuidePage()
        {
            Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
            mainPage.GoToForGuidePage();
        }

        public void OpenForPartnerPage()
        {
            Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
            mainPage.GoToForPartnerPage();
        }

        public void OpenFormForGuides()
        {
            Pages.ForGuidePageObject forGuidePage = new Pages.ForGuidePageObject(_driver);
            forGuidePage.OpenFormForGuides();
        }
        public void OpenFormForPartners()
        {
            Pages.ForPartnerPageObject forGuidePage = new Pages.ForPartnerPageObject(_driver);
            forGuidePage.OpenFormForPartners();
        }
    }
}
