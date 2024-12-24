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
    
    internal class Frames
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


        }
        //[Test]
        public void KeysDown()
        {
            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // frame as a xpath
            IWebElement frame1 = driver.FindElement(By.XPath("is siiting inside and frame"));
            Assert.IsNotNull(frame1);
            driver.SwitchTo().Frame(frame1);


            // driver.SwitchTo().Frame(0);
            //  driver.SwitchTo().Frame(name);
            //  driver.SwitchTo().Frame(id);
        }


    }
}
