using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages;
using SeleniumWebDriverTemplateProject.Tests.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriverTemplateProject.Tests
{
    class TrainTest
    {
        

        [Test]
        public void Rating()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");
            Thread.Sleep(3000);

            var buildOwnComputer = driver.FindElement(By.LinkText("Build your own computer"));
   

            buildOwnComputer.Click();
            Thread.Sleep(3000);
            var buildOwnRating = driver.FindElement(By.CssSelector(".product-reviews-overview a"));
            buildOwnRating.Click();
            Thread.Sleep(3000);
           // driver.Quit();


        }

        [Test]
        public void Register()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");
            Thread.Sleep(3000);

            var buildOwnComputer = driver.FindElement(By.LinkText("Build your own computer"));


            buildOwnComputer.Click();
            Thread.Sleep(3000);
            var buildOwnRating = driver.FindElement(By.CssSelector(".product-reviews-overview a"));
            buildOwnRating.Click();
            Thread.Sleep(3000);
            // driver.Quit();


        }
    }
}
