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

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        [TestCase(TestName = "End To End Final Test")]
        public void E2eTest()
        {  
            //Arrange
            MainMenuPageObject mainMenuPageObject = new MainMenuPageObject(driver);
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            By CreatedUserEditButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-list/table/tbody/tr[25]/td[4]/button[1]"); 
            By NameField = By.XPath("//*[@id=\"mat-input-0\"]"); 
            IWebElement UserName = driver.FindElement(NameField);

            //Act
            addEntityPageObject.CreateUserEntity();
            offersListPageObject.NavigateToOffersList();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 1000)");
            Thread.Sleep(4000); 
            driver.FindElement(CreatedUserEditButton).Click(); 
            Thread.Sleep(2000);

            //Assert
            Assert.That(UserName.GetAttribute("value"), Is.EqualTo("Челбос"));
        }

        [Test]
        public void OpenOffersTest()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.NavigateToMain();
            mainMenu.TapMenuSwitcher();
            mainMenu.TapOffers();
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
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.TapForTestCheckBox();

        }

        [Test]
        public void SetNameTest()
        {
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.SetName("Alex");

        }

        [Test]
        public void SetKeyTest()
        {
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.SetKey("Test");
        }

        [Test]
        public void SelectCategoryTest()
        {
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.SelectCategory(7);
            Thread.Sleep(1000);
        }

        [Test]
        public void TapAddCategoryTest()
        {
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.TapAddCategoryButton();
        }

        [Test]
        public void TapAddNetworkTest()
        {
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
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
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
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
            Thread.Sleep(1000);
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
            Thread.Sleep(1000);
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
            OffersListPageObject offersList = new OffersListPageObject(driver);
            AddEntityPageObject addEntity = new AddEntityPageObject(driver);
            offersList.NavigateToOffersList();
            offersList.TapAddButton();
            Thread.Sleep(1000);
            addEntity.SelectNetwork();
            Thread.Sleep(1000);
        }

        [Test]
        public void SelectGroupTest()
        {
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton();
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
        public void TapDeleteGroupButtonTest()
        {
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton();
            addEntityPageObject.TapAddGroupSegmentPinkButton();
            addEntityPageObject.TapDeleteSegmentButton();
        }

        [Test]
        public void TapAddSegmentButtonTest()
        {
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton();
            addEntityPageObject.TapAddSegmentButton();
        }

        [Test]
        public void TapDeleteSegmentButtonTest()
        {
            By DeleteSegmentButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[4]/mat-card-content/app-form-segments/mat-card/mat-card-content/div/button");
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton();
            addEntityPageObject.TapAddSegmentButton();
            addEntityPageObject.TapDeleteSegmentButton();
            addEntityPageObject.IsAllSegmentsDeleted();
            Thread.Sleep(6000);
        }

        [Test]
        public void SaveButtonTest()
        {
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            addEntityPageObject.CreateUserEntity();
        }
    }
}