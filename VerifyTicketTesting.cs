using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace IntegrationTesting
{
    public class VerifyTicketTest : INavigation
    {
        public IWebDriver driver1, driver2;
        [SetUp]

        public void startBrowser()
        {
            driver1 = new ChromeDriver();
            driver2 = new ChromeDriver();
        }

        [Test]
        public void TestMethod()
        {
            driver1.Url = "https://www.esheba.cnsbd.com/#/login";
            Thread.Sleep(1000);
            IWebElement element = driver1.FindElement(By.Id("email"));
            element.SendKeys("01736161688");
            Thread.Sleep(1000);
            IWebElement password = driver1.FindElement(By.Id("password"));
            password.SendKeys("asdfghjkl");

            Thread.Sleep(1000);
            driver1.FindElement(By.XPath("/html/body/div/section/div/div/div/div/div[2]/div/form/div[4]/div/button")).Click();
            Thread.Sleep(1000);
            driver1.Navigate().GoToUrl("https://www.esheba.cnsbd.com/#/verify-ticket");
            Thread.Sleep(1000);

            IWebElement dropDown = driver1.FindElement(By.XPath(".//*[@id='ticketSource']"));
            SelectElement selectedElement = new SelectElement(dropDown);
            selectedElement.SelectByText("Online Printed"); // dropdown
            Thread.Sleep(1000);
            selectedElement.SelectByText("Counter Printed");
            Thread.Sleep(1000);

            driver2.Url = "https://www.esheba.cnsbd.com/#/verify-ticket";

            IWebElement pin = driver2.FindElement(By.Id("pin"));
            pin.SendKeys("0123456789");
            Thread.Sleep(1000);
            IWebElement mobileNo = driver2.FindElement(By.Id("mobile"));
            mobileNo.SendKeys("01736161688");
            Thread.Sleep(1000);

            driver2.FindElement(By.XPath("/html/body/div/section/div/div[2]/div/div/div/div[2]/div/div[1]/form/button")).Click();
            Thread.Sleep(1000);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver1.Quit();
            driver2.Quit();
        }
        public void Back()
        {
            throw new NotImplementedException();
        }
        public void Forward()
        {
            throw new NotImplementedException();
        }
        public void GoToUrl(string url)
        {
            throw new NotImplementedException();
        }
        public void GoToUrl(Uri url)
        {
            throw new NotImplementedException();
        }
        public void Refresh()
        {
            throw new NotImplementedException();
        }
    }
}