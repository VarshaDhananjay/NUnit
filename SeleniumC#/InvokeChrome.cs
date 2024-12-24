using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectEg.SeleniumC_
{
    internal class InvokeChrome
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //launch chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            //initialize the web driver
            driver = new ChromeDriver();

        }
        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }
        [TearDown]
        public void closebrowser()
        {
            driver.Close();
        }
    }
}
