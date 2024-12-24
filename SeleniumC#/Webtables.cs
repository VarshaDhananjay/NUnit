using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectEg.SeleniumC_
{
    internal class Webtables
    {
        IWebDriver driver;

        //[SetUp]

        public void StartBrowser()

        {



            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            // intialize the web driver 

            driver = new FirefoxDriver();

            // launch the forefox browser

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");

            driver.Manage().Window.Maximize();

        }

        //[Test]

        public void testcase1()

        {

            // fetch the table
            IWebElement table = driver.FindElement(By.XPath("//table[@id = 'table1']"));
            // fecth the rows 
            List<IWebElement> trrow = new List<IWebElement>(table.FindElements(By.XPath("//table[@id = 'table1']/tbody/tr"));
            int rowcount = trrow.Count();
            Console.WriteLine(rowcount);
            // fecth the columns 
            List<IWebElement> tdcol = ndcolew List<IWebElement>(table.FindElements(By.XPath("//table[@id = 'table1']/tbody/tr[1]/td"));
            int colcount = tdcol.Count();
            Console.WriteLine(colcount);
            // cell data text
            IWebElement celldata = driver.FindElement(By.XPath("//table[@id = 'table1']/tbody/tr[1]/td[2]"));
            string text = celldata.Text;
            Console.WriteLine(text);
            Assert.AreEqual("John", text);

        }

        //[TearDown]

        public void tearDownbrowser()

        {

            driver.Close();

        }

    }
}
