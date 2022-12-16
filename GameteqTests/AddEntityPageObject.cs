using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.Debugger;
using OpenQA.Selenium.DevTools.V106.Network;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace GameteqTests
{
    public class AddEntityPageObject
    {
        //"https://test-task.gameteq.com/add" - Add Entity link

        private readonly IWebDriver driver;

        #region PageData

        private readonly By ForTestCheckBox = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[1]/mat-card-title/div/mat-checkbox/label");
        private readonly By SaveButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[1]/mat-card-title/div/button");
        //Base info
        private readonly By NameBox = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[2]/mat-card-content/mat-form-field[1]/div/div[1]/div/input");
        private readonly By NameField = By.XPath("//*[@id=\"mat-input-0\"]");
        private readonly By KeyField = By.XPath("//*[@id=\"mat-input-1\"]");
        //Networks, Category and Group
        private readonly By CategoryField = By.XPath("//*[@id=\"mat-input-2\"]/option[3]");
        private readonly By AddCategoryButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[3]/mat-card-content/mat-form-field[1]/div/div[1]/div[2]/button");
        private readonly By AddNetworksButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[3]/mat-card-content/mat-form-field[2]/div/div[1]/div[2]/button");
        private readonly By AddGroupButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[3]/mat-card-content/mat-form-field[3]/div/div[1]/div[2]/button");
        private readonly By AddSegmentsButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[4]/mat-card-title/button");
        private readonly By EnterTextDialogContainer = By.XPath("//*[@id=\"cdk-overlay-0\"]");
        private readonly By TextFieldAddButton = By.XPath("//*[@id=\"mat-input-3\"]");
        private readonly By CancelButton = By.XPath("//*[@id=\"mat-dialog-0\"]/app-form-simple/div[2]/button[1]");
        private readonly By CreateButton = By.XPath("//*[@id=\"mat-dialog-0\"]/app-form-simple/div[2]/button[2]");
        private readonly By FaceBook = By.XPath("//*[@id=\"mat-option-0\"]/span");
        private readonly By NetworksWord = By.XPath("//*[@id=\"mat-select-0\"]");
        private readonly By GroupWord = By.XPath("//*[@id=\"mat-select-1\"]");
        private readonly By GroupsList = By.XPath("//html/body/div[2]/div[2]/div/div/div");
        private readonly By EngineersWord = By.XPath("/html/body/div[2]/div[2]/div/div/div/mat-option[1]");
        //Segments
        private readonly By OrButtonArea = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[4]/mat-card-content/app-form-segments/mat-card/mat-card-title/mat-radio-group/mat-radio-button[1]");
        private readonly By OrButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[4]/mat-card-content/app-form-segments/mat-card/mat-card-title/mat-radio-group/mat-radio-button[1]/label/div[2]");
        private readonly By AndButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[4]/mat-card-content/app-form-segments/mat-card/mat-card-title/mat-radio-group/mat-radio-button[2]/label/div[2]");
        private readonly By AddGroupBottomButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[4]/mat-card-content/app-form-segments/mat-card/mat-card-title/div/button[1]");
        private readonly By DeleteGroupButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[4]/mat-card-content/app-form-segments/mat-card/mat-card-content/app-form-segments/mat-card/mat-card-title/div/button[3]");
        private readonly By AddSegmentButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[4]/mat-card-content/app-form-segments/mat-card/mat-card-title/div/button[2]");
        private readonly By DeleteSegmentButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[4]/mat-card-content/app-form-segments/mat-card/mat-card-content/div/button");
        private readonly By DeleteSegment2Button = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[4]/mat-card-content/app-form-segments/mat-card/mat-card-content/div[2]/button");
        #endregion

        public AddEntityPageObject(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        public AddEntityPageObject TapForTestCheckBox()
        {
            driver
                  .Manage()
                  .Timeouts()
                  .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(ForTestCheckBox)
                .Click();
            return this;
        }

        public AddEntityPageObject SetName(string name)
        {
            Thread.Sleep(1000);
            driver.FindElement(NameField).SendKeys(name);
            Thread.Sleep(1000);
            return this;
        }

        public AddEntityPageObject SetKey(string key)
        {
            Thread.Sleep(1000);
            driver.FindElement(KeyField).SendKeys(key);
            Thread.Sleep(1000);
            return this;
        }


        /// <summary>
        /// Select category from list. Start count from 1 to 14
        /// </summary>
        /// <param name="categoryIterator">
        /// Should be from 1 to 14
        /// </param>
        /// <returns></returns>
        public AddEntityPageObject SelectCategory(int categoryIterator)
        {
            By xPath = By.XPath("//*[@id=\"mat-input-2\"]/option[" + categoryIterator + "]");

            driver
                  .Manage()
                  .Timeouts()
                  .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(xPath)
                .Click();
            return this;
        }

        public AddEntityPageObject TapAddCategoryButton()
        {
            driver
                  .Manage()
                  .Timeouts()
                  .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(AddCategoryButton)
                .Click();
            return this;
        }

        public AddEntityPageObject TapAddNetworksButton()
        {
            driver
                  .Manage()
                  .Timeouts()
                  .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(AddNetworksButton)
                .Click();
            return this;
        }

        public AddEntityPageObject TapAddGroupButton()
        {
            driver
                  .Manage()
                  .Timeouts()
                  .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(AddGroupButton)
                .Click();
            return this;
        }

        public AddEntityPageObject TapAddSegmentsButton()
        {
            driver
                  .Manage()
                  .Timeouts()
                  .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(AddSegmentsButton)
                .Click();
            return this;
        }

        public AddEntityPageObject EnterTextAddButton(string inputText)
        {
            Thread.Sleep(1000);
            driver.FindElement(EnterTextDialogContainer).Click();
            driver.FindElement(TextFieldAddButton).SendKeys(inputText);
            Thread.Sleep(1000);
            return this;
        }

        public AddEntityPageObject CancelEnteredTextAddButton(string input)
        {
            Thread.Sleep(1000);
            driver.FindElement(EnterTextDialogContainer).Click();
            driver.FindElement(TextFieldAddButton).SendKeys(input);
            Thread.Sleep(1000);
            driver
                .FindElement(CancelButton)
                .Click();
            return this;
        }

        public AddEntityPageObject CreateNewEntityButton(string input)
        {
            Thread.Sleep(1000);
            driver.FindElement(EnterTextDialogContainer).Click();
            driver.FindElement(TextFieldAddButton).SendKeys(input);
            Thread.Sleep(1000);
            driver
                .FindElement(CreateButton)
                .Click();
            return this;
        }

        public AddEntityPageObject SelectNetwork()
        {
            driver
                  .Manage()
                  .Timeouts()
                  .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(NetworksWord)
                .Click();
            Thread.Sleep(1000);
            Boolean isFacebookVisible = driver.FindElement(FaceBook).Displayed;
            if (isFacebookVisible)
            {
                driver
                    .FindElement(FaceBook)
                    .Click(); 
            }
            else
            {
                Assert.Fail();
            }
            var element = driver.FindElement(SaveButton);
            new Actions(driver).MoveToElement(element).MoveByOffset(0, 0).Click().Perform();
            Thread.Sleep(4000);
            return this;
        }

        public AddEntityPageObject SelectGroup()
        {
            driver
                 .Manage()
                 .Timeouts()
                 .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(GroupWord)
                .Click();
            driver
                .FindElement(EngineersWord)
                .Click();
            return this;
        }

        public AddEntityPageObject TapOrButton()
        {
            driver
                 .Manage()
                 .Timeouts()
                 .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(OrButtonArea)
                .Click();
            driver
                .FindElement(OrButton)
                .Click();
            Thread.Sleep(1000);

            return this;
        }
        public AddEntityPageObject TapAndButton()
        {
            driver
                 .Manage()
                 .Timeouts()
                 .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(OrButtonArea)
                .Click();
            driver
                .FindElement(AndButton)
                .Click();
            Thread.Sleep(1000);
            return this;
        }

        public AddEntityPageObject TapAddGroupSegmentPinkButton()
        {
            driver
                 .Manage()
                 .Timeouts()
                 .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(OrButtonArea)
                .Click();
            driver
                .Manage()
                .Timeouts()
                .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(AddGroupBottomButton)
                .Click();
            Thread.Sleep(2000);
            return this;
        }

        public AddEntityPageObject TapDeleteGroupButton()
        {
            driver
                .Manage()
                .Timeouts()
                .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(OrButtonArea)
                .Click();
            driver
                .FindElement(DeleteGroupButton)
                .Click();
            return this;
        }

        public AddEntityPageObject TapAddSegmentButton()
        {
            driver
                .Manage()
                .Timeouts()
                .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(AddSegmentButton)
                .Click();
            Thread.Sleep(3000);
            return this;
        }

        public AddEntityPageObject TapDeleteSegmentButton()
        {
            driver
                .Manage()
                .Timeouts()
                .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(OrButtonArea)
                .Click();
            TapAddSegmentButton();
            driver
                .FindElement(DeleteSegmentButton)
                .Click();
            Thread.Sleep(3000);
            return this;
        }

        public AddEntityPageObject IsAllSegmentsDeleted()
        {
            if (driver.FindElements(By.XPath("/html/body/app-root/mat-sidenav-container/" +
                "mat-sidenav-content/app-form/form/mat-card[4]/mat-card-content/" +
                "app-form-segments/mat-card/mat-card-content/div/button")) != null)
            {
                driver.FindElement(DeleteSegmentButton).Click();
            }

            return this;
        }

        public AddEntityPageObject TapSaveButton()
        {
            By test = By.XPath("<div class=\"cdk-overlay-backdrop cdk-overlay-dark-backdrop cdk-overlay-backdrop-showing\"></div>");
            driver
                .Manage()
                .Timeouts()
                .ImplicitWait = TimeSpan.FromSeconds(10);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0)");
            Thread.Sleep(1000);
            driver
                .FindElement(SaveButton)
                .Click();
            return this;
        }

        public AddEntityPageObject CreateUserEntity()
        {
            OffersListPageObject offersListPageObject = new OffersListPageObject(driver);
            AddEntityPageObject addEntityPageObject = new AddEntityPageObject(driver);
            offersListPageObject.NavigateToOffersList();
            offersListPageObject.TapAddButton();

            //EnterBase info
            addEntityPageObject.SetName("Челбос");
            addEntityPageObject.SetKey("Ключ");
            //Networks, Category and Group
            addEntityPageObject.SelectNetwork();
            addEntityPageObject.SelectCategory(2);
            addEntityPageObject.SelectGroup();
            //Segments 
            addEntityPageObject.TapAddGroupSegmentPinkButton();
            addEntityPageObject.TapSaveButton();

            return this;
        }
    }
}
