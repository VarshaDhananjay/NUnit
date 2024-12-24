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
    internal class Locators
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




        //[Test]
        public void testcase1()
        {


            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/register.php");
            // locators 
            // Id
            IWebElement FirstName = driver.FindElement(By.Id("firstname"));
            FirstName.SendKeys("Varsha");
            // name 
            IWebElement LastName = driver.FindElement(By.Name("lastname"));
            LastName.SendKeys("Dhananjay");
            // xpath 
            IWebElement UserName = driver.FindElement(By.XPath("//input[@id = 'username']"));
            UserName.SendKeys("vd");
            // xpath
            IWebElement Password = driver.FindElement(By.XPath("//input[@name= 'password']"));
            Password.SendKeys("vd123");
            // Link text 
            IWebElement Backtologin = driver.FindElement(By.LinkText("Back to Login"));
            Backtologin.Click();
            // Partial link text
            IWebElement Register = driver.FindElement(By.PartialLinkText("Back to Log"));
            Register.Click();
            //  Css selectorr
            IWebElement Elements = driver.FindElement(By.CssSelector("button[data-bs-target='#collapseOne']"));
            Elements.Click();
            // tag name 
            IWebElement input = driver.FindElement(By.TagName("(//input)[1]"));
            input.SendKeys("qwe");
            // class name 
            IWebElement classname = driver.FindElement(By.ClassName("(//input[@class = 'form-control'])[1]"));
            classname.SendKeys("jkj");

        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
