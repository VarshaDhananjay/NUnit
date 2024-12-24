using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using TestProjectEg.Utilities;

namespace TestProjectEg.SeleniumC_
{
    internal class LoginOrangeHRM : Base
    {

        [Test]
        public void testcase1()
        {
            
            Thread.Sleep(3000);
            IWebElement Ussername = driver.FindElement(By.Name("username"));
            Ussername.SendKeys("Admin");

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("admin123");

            IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            LoginButton.Click();
            Thread.Sleep(3000);
        }

        
    }

}
