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
    class ITest
    {
        IWebDriver driver;  //
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "https://www.esheba.cnsbd.com/#/login"; 
            Thread.Sleep(2000); //make it Stuck
            IWebElement element = driver.FindElement(By.Id("email"));  //kono ekta web ele ke by name diye khuje ber korte pari.. finding ele
            element.SendKeys("01736161688");
            Thread.Sleep(1000);
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("asdfghjkl");
            Thread.Sleep(2000);

            //driver1.FindElement(By.XPath("/html/body/div/section/div/div/div/div/div[2]/div/form/div[4]/div/button")).Click();
            String at = driver.Title; //BR

            String et = "Bangladesh Railway";
            if (at == et)
            {
                Console.WriteLine("Test Successful");
                IWebElement element2 =
                driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div/div[2]/div/form/div[4]/div/button"));
        
                element2.Click();
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
