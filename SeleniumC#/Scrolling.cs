using OpenQA.Selenium.Edge;
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
    internal class Scrolling
    {
        IWebDriver driver;

        //[SetUp]
        public void startBrowser()

        {
            //launch chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            //initialize the web driver

            driver = new EdgeDriver();

        }

        //[Test]
        public void testcase1()

        {

            //launch application URL

            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();


            IWebElement amazonScience = driver.FindElement(By.XPath("//a[normalize-space()='Amazon Science']"));

            new OpenQA.Selenium.Interactions.Actions(driver)
                .ScrollToElement(amazonScience)
                .Click(amazonScience)
                .Perform();

            Thread.Sleep(5000);


        }
        //[Test]
        public void test()
        {
            //Scroll down
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)EdgeDriver;

            // 0 - x coordinate , 500 - y coordinate
            js.ExecuteScript("window.scrollBy(0,500)", "");

            //Scroll up
            Thread.Sleep(5000);

            // 0 - x coordinate , 500 - y coordinate
            js.ExecuteScript("window.scrollBy(0,-300)", "");

            js.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)", "");


        }

        //[TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
//driver.Navigate().GoToUrl("https://www.amazon.in/");

//driver.Manage().Window.Maximize();

//Thread.Sleep(2000);

//  IWebElement amaoznscienes = driver.FindElement(By.XPath("//a[normalize-space()='Amazon Science']"));

//new OpenQA.Selenium.Interactions.Actions(driver)

//  .ScrollToElement(amaoznscienes)

//.Perform();

// java script execitor for scrolling

//IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

// verical down scroll

// 0 - x coordinates

// 400 - y cooridinates

// down scroll

//Thread.Sleep(2000);

//js.ExecuteScript("window.scrollBy(0,600)", "");

// scroll up

//Thread.Sleep(2000);

//js.ExecuteScript("window.scrollBy(0,-400)", "");


// horizonatl dwn scroll

// 600 - x coordinates

// 0 - y cooridinates

// rihght scroll

// js.ExecuteScript("window.scrollBy(600 ,0)" , "");

// left up

// js.ExecuteScript("window.scrollBy(-500,0)", "");

