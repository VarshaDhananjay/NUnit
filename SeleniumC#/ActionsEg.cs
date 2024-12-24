using OpenQA.Selenium.Firefox;
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
    internal class ActionsEg
    {
        IWebDriver driver;

        //[SetUp]

        public void StartBrowser()

        {

            // confifgure the web driver manager to set up the chrome capabilities

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            // intialize the web driver 

            driver = new FirefoxDriver();

            // launch the forefox browser

            driver.Navigate().GoToUrl("https://www.amazon.in/");

            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }

        //[Test]

        public void testcase1()

        {

            IWebElement Primes = driver.FindElement(By.XPath("//span[normalize-space()='Prime']"));

            IWebElement LatestMovies = driver.FindElement(By.XPath("//img[@id='multiasins-img-link']"));

            new Actions(driver)

              .MoveToElement(Primes)

              .MoveToElement(LatestMovies)

              .Click().Perform();

            Thread.Sleep(1000);

            

        }

        //[TearDown]

        public void tearDownbrowser()

        {

            driver.Close();

        }


    }
}
