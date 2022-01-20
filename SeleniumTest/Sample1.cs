using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    internal class Sample1
    {
        //create the reference for the browser
        IWebDriver driver = new ChromeDriver();

        public void Initialize()
        {
            //navigate to URL
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            //maximize the browser window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        public void ExecuteTest()
        {

        }

        public void EndTest()
        {

        }

    }
}
