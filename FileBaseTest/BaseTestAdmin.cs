using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace AutomationTest_Ngan_CNPM.FileBaseTest
{
    public class BaseTestAdmin
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://home-dev.epicpartner.vn/home");
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
