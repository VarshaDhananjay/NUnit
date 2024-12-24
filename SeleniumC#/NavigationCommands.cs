using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectEg.SeleniumC_
{
    internal class NavigationCommands
    {

        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome 
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            driver = new ChromeDriver();
        
            driver.Manage().Window.Maximize();

        }




        [Test]
        public void testcase1()
        {


            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.Navigate().Back();
            Thread.Sleep(3000);
            driver.Navigate().Forward();
            Thread.Sleep(3000);
            driver.Navigate().Refresh();

        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}