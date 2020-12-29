﻿using NUnit.Framework;
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
    class NavigationTesting : INavigation
    {
        public INavigation Navigation;
        public IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void NavigationTestingMethod()
        {
            driver.Url = "https://www.esheba.cnsbd.com/#/";
            Thread.Sleep(2000);
            driver.Url = "https://www.esheba.cnsbd.com/#/register";
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.Id("name"));
            element.SendKeys("Safayat");
            Thread.Sleep(2500);
            driver.Navigate().Refresh();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Navigate().Forward();
            Thread.Sleep(2000);
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
