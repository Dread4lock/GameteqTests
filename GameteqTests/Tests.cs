using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

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

        [Test]
        public void SelectCategoryTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            mainMenu.NavigateToMain();
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.SelectCategory(7);
            Thread.Sleep(1000);
        }

        [Test]
        public void TapAddCategoryTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            mainMenu.NavigateToMain();
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.TapAddCategoryButton();
        }

        [Test]
        public void TapAddNetworkTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            mainMenu.NavigateToMain();
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.TapAddNetworksButton();
        }

        [Test]
        public void TapAddGroupTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            mainMenu.NavigateToMain();
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.TapAddGroupButton();
        }

        [Test]
        public void TapAddSegmentsTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            mainMenu.NavigateToMain();
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.TapAddSegmentsButton();

        }

        [Test]
        public void EnterTextAddCategoryTest()
        {
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.TapAddCategoryButton();
            addEntity.EnterTextAddButton("test");
            Thread.Sleep(2000);
        }

        [Test]
        public void CancelEnteredTextCategoryTest()
        {
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.TapAddCategoryButton();
            addEntity.CancelEnteredTextAddButton("CANCEL_THIS");
            Thread.Sleep(2000);
        }

        [Test]
        public void CreateNewEntityCategoryTest()
        {
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.TapAddCategoryButton();
            addEntity.CreateNewEntityButton("CREATE_THIS");
            Thread.Sleep(1000);
        }

        [Test]
        public void CreateNewNetworkTest()
        {
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.TapAddNetworksButton();
            Thread.Sleep(1000);
            addEntity.CreateNewEntityButton("NEW_NETWORK");
            Thread.Sleep(1000);
        }

        [Test]
        public void CreateNewGroupTest()
        {
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.TapAddGroupButton();
            Thread.Sleep(1000);
            addEntity.CreateNewEntityButton("NEW_GROUP");
            Thread.Sleep(1000);
        }

        [Test]
        public void SelectNetworkTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            mainMenu.NavigateToMain();
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.SelectNetwork();
            Thread.Sleep(6000);
        }

        [Test]
        public void SelectGroupTest()
        {
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton();
            Thread.Sleep(1000);
            addEntityPageObject.SelectGroup();
        }

        [Test]
        public void TapAddSegmentTest()
        {
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton();
            Thread.Sleep(1000);
            addEntityPageObject.TapAddSegmentsButton();
        }

        [Test]
        public void CreateNewSegmentTest()
        {
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton();
            Thread.Sleep(1000);
            addEntityPageObject.TapAddSegmentsButton();
            addEntityPageObject.CreateNewEntityButton("CHECK");
            Thread.Sleep(1000);
        }

        [Test]
        public void TapOrButtonTest()
        {
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton();
            addEntityPageObject.TapOrButton();
        }

        [Test]
        public void TapAndButtonTest()
        {
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton();
            addEntityPageObject.TapAndButton();
        }

        [Test]
        public void TapAddGroupBottomPinkButtonTest()
        {
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton();
            addEntityPageObject.TapAddGroupSegmentPinkButton(); 
        }

        [Test]
        public void TapDeleteGroupButton()
        {
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton();
            addEntityPageObject.TapAddGroupSegmentPinkButton();
            addEntityPageObject.TapDeleteSegmentButton(); 
        }
        
        [Test]
        public void TapAddSegmentButton()
        {
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton(); 
            addEntityPageObject.TapAddSegmentButton();
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}