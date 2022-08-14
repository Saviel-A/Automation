using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Tests;
using System;

namespace Selenium
{
    [TestClass]
    public class ExampleScenarios : BaseTest
    {
        [TestMethod]
        public void ExampleTest()
        {
            RunScenario(() =>
           {
               Application.ExampleDomain.NavigateToHomePage(TestContext.Properties["Url"].ToString());

           });
        }
    }
}
