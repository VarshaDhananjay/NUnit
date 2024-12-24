using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectEg.SeleniumC_
{
    internal class ContextClick
    {
        IWebDriver driver;

        [SetUp]

        public void StartBrowser()

        {

            

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            // intialize the web driver 

            driver = new FirefoxDriver();

            // launch the forefox browser

            driver.Navigate().GoToUrl("https://www.amazon.in/");

            driver.Manage().Window.Maximize();

        }

        [Test, Category("Regression")]

        public void testcase1()

        {

            IWebElement BestSeller = driver.FindElement(By.XPath("//a[contains(text(),\"Best Sellers\")]"));

            new Actions(driver)

              .ContextClick(BestSeller)

              .Perform();

            Thread.Sleep(1000);

        }

        [TearDown]

        public void tearDownbrowser()

        {

            driver.Close();

        }
    }
}
