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
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            driver.Manage().Window.FullScreen();
            //driver.Close();

            driver.FindElement(By.XPath("//div/form/input[@type='text']")).SendKeys("standard_user");
            driver.FindElement(By.XPath("//div/form/input[@type='password']")).SendKeys("secret_sauce");

            //click on login button

            driver.FindElement(By.XPath("//div/form/input[@id='login-button']")).Click();
             
            

            Thread.Sleep(5000);


            String actualvalue = driver.FindElement(By.XPath("//div[text()='Products']")).Text;
            Assert.True(actualvalue.Contains("Products"));
       
        

            driver.Close();
            
        }
        [Test]
        public void Negative()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            driver.Manage().Window.FullScreen();

            var title = driver.Title;
            Console.WriteLine("Page Title : ");
            Console.WriteLine(title);

            //username pass
            driver.FindElement(By.XPath("//div/form/input[@type='text']")).SendKeys("standard_user");
            driver.FindElement(By.XPath("//div/form/input[@type='password']")).SendKeys("secret_saucee");

            //click on login button

            driver.FindElement(By.XPath("//div/form/input[@id='login-button']")).Click();

            //assertion
            String actualvalue = driver.FindElement(By.XPath("//div/form/h3[text()='Username and password do not match any user in this service']")).Text;
            Assert.True(actualvalue.Contains("Username and password do not match any user in this service"));



            driver.Close();

        }

    }
}
