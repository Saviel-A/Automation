using Selenium.Browsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Pages
{
    public class ExamplePage : BasePage
    {
        new Browser Browser { get; set; }

        public ExamplePage(Browser browser) : base(browser)
        {
            Browser = browser;
        }

        public void NavigateToHomePage(string url)
        {
            Browser.NavigateToUrl(url);
        }
    }
}
