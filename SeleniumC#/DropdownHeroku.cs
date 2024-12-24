using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectEg.SeleniumC_
{
    internal class DropdownHeroku
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the forefox browser

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

            IWebElement DropDown = driver.FindElement(By.Id("dropdown"));
            Assert.IsNotNull(DropDown);
            var select = new SelectElement(DropDown);
            //Select by value
            select.SelectByValue("1");
            Thread.Sleep(1000);
            //Select by text
            select.SelectByText("Option 2");

            Thread.Sleep(2000);

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
