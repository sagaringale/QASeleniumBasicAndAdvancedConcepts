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
            driver.Manage().Window.FullScreen();
            //driver.Close();
            var text = driver.FindElement(By.Id("APjFqb"));
            text.SendKeys("github.com");
            text.SendKeys(Keys.Enter);
            
       
           Thread.Sleep(5000);

            driver.SwitchTo().NewWindow(WindowType.Tab);
            var googlebutton = driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[12]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[2]/td[1]/div[2]/div[1]/div[1]/div[1]/h3[1]/a[1]"));
            googlebutton.Click();


            Thread.Sleep(15000);

            driver.Close();
            


        }

    }
}
