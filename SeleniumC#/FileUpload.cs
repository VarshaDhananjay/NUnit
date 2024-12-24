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
    internal class FileUpload
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the forefox browser

            
        }

        [Test]
        public void testcase1()
        {

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement browse = driver.FindElement(By.Id("file-upload"));
            browse.SendKeys("C:\\Users\\vardh\\Desktop\\Screenshot 2024-05-22 142723.png");
            Thread.Sleep(1000);
            IWebElement upload = driver.FindElement(By.Id("file-submit"));
            upload.Click();
            Thread.Sleep(1000);
            IWebElement fileuploadedmsg = driver.FindElement(By.XPath("//h3[normalize-space()='File Uploaded!']"));
            if (fileuploadedmsg.Displayed)
            {

                Console.WriteLine("The file is uploaded properly");
            }
            else
            {

                Console.WriteLine("\"The file is not  uploaded properly");
            }





        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
