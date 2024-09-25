
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumQA
{
    public class Tests
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

        [Test]
        public void CaptureTitle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");

            //Capture Title

            var title = driver.Title;
            Console.WriteLine("Page Title : ");
            Console.WriteLine(title);

            var url = driver.Url;
            Console.WriteLine("Page URl : ");
            Console.WriteLine(url);
            Thread.Sleep(3000);
            driver.Close();

        }
        [Test]
        public void NavigationMethods()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().Refresh();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Close();
        }

        [Test]
        public void PlayWithTextBox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://facebook.com");

            //enter the value in the textbox using Sendkeys

            IWebElement textBox = driver.FindElement(By.XPath("//input[@id='email']"));
            textBox.SendKeys("test@gmail.com");

            Thread.Sleep(5000);

            //Enter the valule in the textbox without using sendkeys


            var java = (IJavaScriptExecutor)driver;
            java.ExecuteScript("document.getElementById('email').value='Test123@gmail.com'");
            Thread.Sleep(5000);
            driver.Close();

            //Capture text from textbox QASeleniumBasicAndAdvancedConcepts

            var text = textBox.GetAttribute("value");
            Console.WriteLine(text);

            //clear text for text Box 

            textBox.Clear();
            Thread.Sleep(5000);


            driver.Close();

        }
        [Test]
        public void PlayWithButton()
        {

        }

    }
}