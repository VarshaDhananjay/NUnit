using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using AngleSharp.Io;

namespace TestProjectEg.SeleniumC_
{
    internal class FileDownload
    {

        IWebDriver driver;
        //[SetUp]
        public void StartBrowser()
        {
            
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            
            driver = new FirefoxDriver();
           

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
        }

        //[Test]
        public void testcase1()
        {
            
            Thread.Sleep(1000);

            IWebElement downloadLink = driver.FindElement(By.LinkText("data.png"));
            downloadLink.Click();

            // Wait for the file to download
            Thread.Sleep(5000); 

            // Verify 
            string filePath = "C:\\Users\\vardh\\Downloads\\data.png"; ;
            Assert.IsTrue(File.Exists(filePath), "File not downloaded.");
        }

        //[TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
