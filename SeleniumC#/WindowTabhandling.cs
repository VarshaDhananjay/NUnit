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
    internal class WindowTabhandling
    {
        IWebDriver driver;


        //[SetUp]
        public void startbrowser()
        {


            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the chrome browser
            

        }

        //[Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            driver.Manage().Window.Maximize();
            // fecth the parent window handle 
            string parenthandle = driver.CurrentWindowHandle;
            Console.WriteLine(parenthandle);
            Thread.Sleep(1000);
            IWebElement clickhere = driver.FindElement(By.XPath("//a[normalize-space()='Click Here']"));
            clickhere.Click();
            Thread.Sleep(1000);
            // fecth the window handles of all the windows - two windows are opened
            IList<string> windowhandles = new List<string>(driver.WindowHandles);
            // move the control to child window
            driver.SwitchTo().Window(windowhandles[1]);
            string title = driver.Title;
            Console.WriteLine(title);
            driver.Close();

            Thread.Sleep(1000);
            driver.SwitchTo().Window(windowhandles[0]);
            string parenttitle = driver.Title;
            Console.WriteLine(parenttitle);
            Assert.AreEqual("The Internet", parenttitle);
        }
        //[TearDown]
        public void closebrowser()
        {
            driver.Close();
        }
    }
}
