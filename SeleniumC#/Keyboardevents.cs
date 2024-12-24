using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace TestProjectEg.SeleniumC_
{
    internal class Keyboardevents
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

            
        }

        [Test]
        public void KeysDown()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(6000);
            new Actions(driver)
                .KeyDown(Keys.Shift)
                .SendKeys("varsha")
                .Perform();
            Thread.Sleep(2000);

        }

        

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
