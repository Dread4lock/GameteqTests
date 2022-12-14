using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;

namespace GameteqTests
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void OpenOffersTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.NavigateToMain();
            mainMenu.TapMenuSwitcher();
            mainMenu.TapOffers();
            Assert.Pass();
        }

        [Test]
        public void TapAddButtonTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            OffersListPageObject offersList = new OffersListPageObject(driver);

            mainMenu.NavigateToMain();
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
        }

        [Test]
        public void TapEditButtonTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            OffersListPageObject offersList = new OffersListPageObject(driver);

            mainMenu.NavigateToMain();
            offersList.NavigateToOffersList();
            offersList.TapEditButton();
        }

        [Test]
        public void TapDeleteButtonTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            OffersListPageObject offersList = new OffersListPageObject(driver);

            mainMenu.NavigateToMain();
            offersList.NavigateToOffersList();
            offersList.TapDeleteButton();
        }

        [Test]
        public void TapForTestCheckBoxTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            mainMenu.NavigateToMain();
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.TapForTestCheckBox();

        }

        [Test]
        public void SetNameTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            mainMenu.NavigateToMain();
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.SetName("Alex");

        }

        [Test]
        public void SetKeyTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            mainMenu.NavigateToMain();
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.SetKey("Test");

        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}