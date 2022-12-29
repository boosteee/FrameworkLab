using NUnit.Framework;

namespace GitHubAutomation
{
    [TestFixture]
    public class SmokeTests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void SortBatumiToursByPopularity()
        {
            steps.OpenBatumiPage();
            steps.SortBatumiToursByPopularity();
        }

        [Test]
        public void SearchForIndividualBatumiTours()
        {
            steps.SearchForBatumiIndividualTours();
        }

        [Test]
        public void LookForInfoAboutPrometheusCavePage()
        {
            steps.OpenTbilisiPage();
            steps.OpenPrometheusCavePage();
        }

        [Test]
        public void LookForReviewsAboutTheCheapestTour()
        {
            steps.OpenAllToursPage();
            steps.SearchForTheCheapestTour();
            steps.OpenTheCheapestTourPage();
            steps.ScrollToCheapestTourReviews();
        }
        [Test]
        public void CheckAgreement()
        {
            steps.OpenUserAgreements();
        }

        [Test]
        public void SendMessageToGuide()
        {
            steps.OpenTbilisiPage();
            steps.OpenTbilisiFirstTourPage();
            steps.OpenSendMessagePage();
        }

        [Test]
        public void TourBooking()
        {
            steps.OpenTbilisiPage();
            steps.OpenTbilisiFirstTourPage();
            steps.BookAFirstTbilisiTour();
        }

        [Test]
        public void InfoAboutGuide()
        {
            steps.OpenBatumiPage();
            steps.OpenBatumiFirstTourPage();
            steps.OpenBatumiFirstTourGuidePage();
        }

        [Test]
        public void OpenFormForGuide()
        {
            steps.OpenForGuidePage();
            steps.OpenFormForGuides();
        }

        [Test]
        public void OpenFormForPartners()
        {
            steps.OpenForPartnerPage();
            steps.OpenFormForPartners();
        }
    }
}
