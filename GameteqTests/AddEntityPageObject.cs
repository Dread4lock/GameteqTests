using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameteqTests
{
    public class AddEntityPageObject
    {
        //"https://test-task.gameteq.com/add" - Add Entity link

        private IWebDriver driver;

        By ForTestCheckBox = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[1]/mat-card-title/div/mat-checkbox/label");

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
    }
}
