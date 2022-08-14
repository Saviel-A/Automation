using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.Browsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Tests
{
    public abstract class BaseTest
    {
        protected bool IsTestFailed = false;
        public TestContext TestContext { get; set; }
        protected Application Application { get; private set; }
        protected Browser Browser;

        public BaseTest()
        {

        }
        protected void RunScenario(Action action)
        {
            var browserType = TestContext.Properties["BrowserType"].ToString();

            try
            {
                var browserInit = new BrowserFactory().Create(browserType);
                Browser = new Browser(browserType, browserInit);
                Application = new Application(Browser);
                action();
            }
            catch (Exception e)
            {
                Browser.Close();
                Assert.Fail(e.Message);
            }
            finally
            {
                Browser.Close();
                if (IsTestFailed)
                    Assert.Fail("Test failed!");
            }
        }
    }
}
