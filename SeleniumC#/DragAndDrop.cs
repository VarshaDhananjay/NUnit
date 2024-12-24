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
    internal class DragAndDrop
    {

        IWebDriver driver;

        [SetUp]

        public void StartBrowser()

        {

            

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            // intialize the web driver 

            driver = new FirefoxDriver();

            // launch the forefox browser

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");

            driver.Manage().Window.Maximize();

        }

        [Test,Category("Regression")]

        public void testcase1()

        {

            IWebElement Source = driver.FindElement(By.XPath("//div[@id='column-a']"));

            IWebElement Dest = driver.FindElement(By.XPath("//div[@id='column-b']"));

            new Actions(driver)

                .DragAndDrop(Source, Dest)

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
