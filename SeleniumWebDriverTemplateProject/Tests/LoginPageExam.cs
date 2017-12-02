using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages;
using SeleniumWebDriverTemplateProject.Tests.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SeleniumWebDriverTemplateProject.Tests
{
    class HomePageTests : DesktopSeleniumTestFixturePrototype
    {
        public HomePageTests(Browsers browser) : base(browser)
        { }

        [Test]
        public void NavigateToHomePageTest()
        {
            var homePageInstance = HomePage.NavigateTo(this.Driver);
            Thread.Sleep(4000);
            homePageInstance.AllProductButton.Click();
            Thread.Sleep(4000);
            //Assert.AreEqual("home", HomePage.HomeButton.TagName);



        }

        [Test]
        [Category("Use case tests")]
        public void HomePageTestLatestProducts()
        {
            var homePageInstance = HomePage.NavigateTo(this.Driver);
            Thread.Sleep(4000);
            homePageInstance.HomeButton.Click();
            Thread.Sleep(4000);
            //Assert.AreEqual("home", HomePage.HomeButton.TagName);
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Latest Products", homePageInstance.LatestProducts.Text, "Latest products footer");
                Assert.AreEqual(true, homePageInstance.LatestProducts.Displayed, "Latest products visible");
                Assert.Greater(homePageInstance.LatestProductsList.Count(), 0, "check cnt of Latest products in list is greater then 0");
                Assert.AreEqual(true, homePageInstance.LatestProductsList.Last().Displayed, "check Latest products last element visible");
                Assert.AreEqual(true, homePageInstance.LatestProductsList.First().Displayed, "check Latest products first element visible");

                foreach (IWebElement element in homePageInstance.LatestProductsList)
                {
                    Assert.AreEqual(true, element.Displayed);
                }
            });


        }
    }
}
