using Selenium.Browsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Pages
{
    public abstract class BasePage
    {
        protected Browser Browser { get; set; }

        public BasePage(Browser browser)
        {
            Browser = browser;
        }
    }
}
