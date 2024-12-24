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
    internal class BrowserCommands
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            driver = new ChromeDriver();
            // launch the chrome browser
            driver.Manage().Window.Maximize();

        }




        [Test, Category("Sanity")]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            string title = driver.Title;
            Console.WriteLine(title);
            string url = driver.Url;
            Console.WriteLine(url);
            string page = driver.PageSource;
            Console.WriteLine(page);

        }


        [TearDown]
        public void tearDownbrowser()
        {
            //CLOSE THE OPENED BROWSER SESSION
            driver.Close();
            //WILL CLOSE ALL THE BROWSER SESSIONS
            driver.Quit();
        }
    }
}
