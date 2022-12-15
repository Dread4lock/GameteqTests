using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GameteqTests
{
    public class MainMenuPageObject 
    {
        //"https://test-task.gameteq.com/dashboard" - MainMenu link

        private readonly IWebDriver driver; 

        By MenuSwitcher = By.XPath("/html/body/app-root/mat-toolbar/mat-toolbar-row/mat-slide-toggle/label/div/div/div[1]");
        By OffersSideButton = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav/div/div/button[2]");
         
        public MainMenuPageObject(IWebDriver _driver)
        {
            driver = _driver;
        }

        public MainMenuPageObject NavigateToMain()
        {
            driver.Navigate().GoToUrl("https://test-task.gameteq.com/dashboard");
            return this;
        }

        public MainMenuPageObject TapMenuSwitcher()
        {
            driver
                  .Manage()
                  .Timeouts()
                  .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(MenuSwitcher)
                .Click(); 
            return this;
        }

        public MainMenuPageObject TapOffers()
        {
            driver
                 .Manage()
                 .Timeouts()
                 .ImplicitWait = TimeSpan.FromSeconds(10);
            driver
                .FindElement(OffersSideButton)
                .Click();
            return this;
        }
    }
}
