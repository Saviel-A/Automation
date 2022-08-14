using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Browsers
{
    public class BrowserFactory
    {
        public IWebDriver Create(string browserType)
        {

            switch (browserType)
            {
                case "Chrome":
                    return new ChromeDriver();

                //case "IE":
                //    return new InternetExplorerBrowser(listener);

                //case "Firefox":
                //    return new FirefoxBrowser(listener);

                default:
                    throw new ArgumentException($"Browser type '{0}' is not supported", browserType);
            }
        }
    }
}
