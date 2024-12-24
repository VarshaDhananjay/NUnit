using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectEg.SeleniumC_
{
    internal class Alerts1
    {
        IWebDriver driver;


        //[SetUp]
        public void startbrowser()
        {


            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the chrome browser
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");

        }




        //[Test]
        public void testcase1()
        {
            IWebElement infoalert = driver.FindElement(By.XPath("//input[@id = 'alertbtn']"));
            infoalert.Click();



            // switch the control to alert or the pop up

            IAlert alt = driver.SwitchTo().Alert();

            // click on OK button

            alt.Accept();

            Thread.Sleep(3000);

            // confirmnational alert

            IWebElement ConfAlert = driver.FindElement(By.XPath("//input[@id = 'confirmbtn']"));
            ConfAlert.Click();

            alt.Dismiss();

            Thread.Sleep(3000);
        



            
        }
    }

}