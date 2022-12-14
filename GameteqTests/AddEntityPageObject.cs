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
        By NameBox = By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-form/form/mat-card[2]/mat-card-content/mat-form-field[1]/div/div[1]/div/input");
        By NameField = By.XPath("//*[@id=\"mat-input-0\"]");
        By KeyField = By.XPath("//*[@id=\"mat-input-1\"]");

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
            Thread.Sleep (1000);
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

    }
}
