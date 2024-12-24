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
    internal class LoginSauceDemo
    {
        IWebDriver driver;

        [SetUp]
        public void startbrowser()
        {
            // launch browser
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();

        }

        //[Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            IWebElement Ussername = driver.FindElement(By.Id("user-name"));
            Ussername.SendKeys("standard_user");
            Thread.Sleep(3000);
            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");
            Thread.Sleep(3000);
            IWebElement LoginButton = driver.FindElement(By.Id("login-button"));
            LoginButton.Click();
            Thread.Sleep(3000);
            IWebElement Products = driver.FindElement(By.XPath("//div[@class='product-label']"));
            //DISPLAYED VALIDATION
            if (Products.Displayed)
            {
                Console.WriteLine("user is on the homepage");
            }
            else
            {
                Console.WriteLine("User is no on the home page");
            }

            //ASSERTION CLASS VALIDATION
            
            string actualTest = Products.Text;
            string expectedvalue = "Products";
            Assert.AreEqual(actualTest, expectedvalue);
        }
        

        [TearDown]
        public void closebrowser()
        {
            driver.Close();
        }                                                                                                                                                                                 
    }
}
