using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace TestProjectEg.SeleniumC_
{
    internal class Ecommerce
    {

        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {


            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the chrome browser
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");

        }




        [Test]
        public void testcase1()
        {
            Thread.Sleep(2000);


            IWebElement UName = driver.FindElement(By.Name("user-name"));
            UName.SendKeys("standard_user");



            Thread.Sleep(2000);
            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");

            Thread.Sleep(2000);

            IWebElement LoginButton = driver.FindElement(By.Id("login-button"));
            LoginButton.Click();
            Thread.Sleep(3000);


            IWebElement AddToCart = driver.FindElement(By.XPath("//button[@class='btn_primary btn_inventory']"));
            AddToCart.Click();
            Thread.Sleep(3000);


            IWebElement CartButton = driver.FindElement(By.XPath("//a[contains(@class, 'shopping_cart_link')]"));
            CartButton.Click();
            Thread.Sleep(3000);


            IWebElement Checkout = driver.FindElement(By.XPath("//a[@href='./checkout-step-one.html']"));
            Checkout.Click();
            Thread.Sleep(3000);


            IWebElement Fname = driver.FindElement(By.XPath("//input[@id='first-name']"));
            Fname.SendKeys("Varsha");



            Thread.Sleep(2000);
            IWebElement LName = driver.FindElement(By.Id("last-name"));
            LName.SendKeys("Dhananjay");
            Thread.Sleep(2000);

            IWebElement PCode = driver.FindElement(By.Id("postal-code"));
            PCode.SendKeys("555555");
            Thread.Sleep(2000);

            IWebElement ContinueBtn = driver.FindElement(By.XPath("//input[@value='CONTINUE']"));
            ContinueBtn.Click();
            Thread.Sleep(2000);


            IWebElement FinishBtn = driver.FindElement(By.XPath("//a[text()='FINISH']"));
            FinishBtn.Click();
            Thread.Sleep(2000);

            IWebElement confirmationMessage = driver.FindElement(By.XPath("//h2[text()='THANK YOU FOR YOUR ORDER']"));
            Assert.IsNotNull(confirmationMessage, "Order confirmation message not found!");

        }



        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}