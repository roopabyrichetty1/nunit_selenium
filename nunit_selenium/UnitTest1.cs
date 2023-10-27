using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace nunit_selenium
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            ChromeOptions chromeoptions = new ChromeOptions();
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.bentley.com");
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}