using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQA
{
    public class test1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LaunchChrome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Close();
        }

    }
}
