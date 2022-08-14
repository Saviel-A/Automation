using Selenium.Browsers;
using Selenium.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class Application
    {
        public Browser Browser { get; set; }
        public ExampleDomain ExampleDomain { get; set; }

        public Application(Browser browser)
        {
            Browser = browser;
            ExampleDomain = new ExampleDomain(this);
        }
    }
}
