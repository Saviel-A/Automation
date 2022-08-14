using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Browsers
{
    public class Browser
    {
        public IWebDriver _driver;

        public Browser(string name, IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void Close()
        {
            _driver.Close();
        }

        public IWebElement WaitForElement(By by)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(by));
            element.Click();
            return element;
        }
    }
}
