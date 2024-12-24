using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using TestProjectEg.SeleniumC_;
namespace TestProjectEg.Utilities
{
    public class Base
    {
        public IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            
            String browserName = System.Configuration.ConfigurationManager.AppSettings["browser"];
            // launch the chrome browser
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            
            driver.Manage().Window.Maximize();

        }
        public void InitBrowser(string browserName)
        {
            switch(browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    
                    break;
                case "Chrome":

                    // confifgure the web driver manager to set up the chrome capabilities
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    // intialize the web driver 
                    driver = new ChromeDriver();
                    break;

                case "Edge":
                    // confifgure the web driver manager to set up the chrome capabilities
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    // intialize the web driver 
                    driver = new ChromeDriver();
                    break;

            }
        }
        [TearDown]
        public void TearDown()
        {

            if (driver != null)
            {

                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }
    }
}

