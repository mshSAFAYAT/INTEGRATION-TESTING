using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace INTEGRATION_TESTING
{
    class DashBoardTesting : INavigation
    {
        INavigation Navigation;
        public IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestMethod()
        {
            driver.Url = "https://www.esheba.cnsbd.com/#/login";
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.Id("email"));
            element.SendKeys("01736161688");
            Thread.Sleep(1000);
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("asdfghjkl");

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div/div[2]/div/form/div[4]/div/button")).Click();

            driver.Navigate().GoToUrl("https://www.esheba.cnsbd.com/#/dashboard");
            Thread.Sleep(2000);
       
            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            //profile update
            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div[2]/div/a[6]")).Click();
            Thread.Sleep(2000);
            //see upcoming journey
            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div[2]/div/a[8]")).Click();
            Thread.Sleep(2000);
            //see previous journey
            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div[2]/div/a[9]")).Click();
            Thread.Sleep(2000);
            //see previous journey

            ///html/body/div/div[2]/nav/div/div/ul/li[6]/a
        }
        public void Back()
        {
            Navigation.Back();
        }

        public void Forward()
        {
            Navigation.Forward();
        }

        public void GoToUrl(string url)
        {
            Navigation.GoToUrl(url);
        }

        public void GoToUrl(Uri url)
        {
            Navigation.GoToUrl(url);
        }

        public void Refresh()
        {
            Navigation.Refresh();
        }


        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
