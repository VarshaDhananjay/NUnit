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
    internal class DoubleClick
    {
        IWebDriver driver;

        [SetUp]

        public void StartBrowser()

        {

           

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            

            driver = new FirefoxDriver();

           

            driver.Navigate().GoToUrl("https://www.amazon.in/");

            driver.Manage().Window.Maximize();

        }

        [Test, Category("Sanity")]

        public void testcase1()

        {


            IWebElement TdyDeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));

            new Actions(driver)

              .DoubleClick(TdyDeal)

              .Perform();

            Thread.Sleep(6000);



        }

        [TearDown]

        public void tearDownbrowser()

        {

            driver.Close();

        }


    }
}

