using Selenium.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Domains
{
    public class ExampleDomain : BaseDomain
    {
        public ExampleDomain(Application application) : base(application)
        {

        }

        public void NavigateToHomePage(string url)
        {
            var homePage = new ExamplePage(Application.Browser);
            homePage.NavigateToHomePage(url);

        }
    }
}
