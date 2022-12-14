using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameteqTests
{
    public class OffersListPageObject
    {
        //https://test-task.gameteq.com/list - OffersList Link

        private IWebDriver driver;

        By AddButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-list/button");
        By EditButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-list/table/tbody/tr[1]/td[4]/button[1]");
        By DeleteButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-list/table/tbody/tr[1]/td[4]/button[2]");

        public OffersListPageObject NavigateToOffersList()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.NavigateToMain(); 
            mainMenu.TapMenuSwitcher();
            mainMenu.TapOffers();
            return this;
        }

        public OffersListPageObject(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        public OffersListPageObject TapAddButton()
        {
            driver
                  .Manage()
                  .Timeouts()
                  .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(AddButton)
                .Click();
            return this;
        }

        public OffersListPageObject TapEditButton()
        {
            driver
                  .Manage()
                  .Timeouts()
                  .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(EditButton)
                .Click();
            return this;
        }

        public OffersListPageObject TapDeleteButton()
        {
            driver
                  .Manage()
                  .Timeouts()
                  .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(DeleteButton)
                .Click();
            return this;
        }

    }
}
