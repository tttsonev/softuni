using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
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
    class NavigationBarTests : DesktopSeleniumTestFixturePrototype
    {
        public NavigationBarTests(Browsers browser) : base(browser)
        { }


        [Test]
        [Category("Use case tests")]
        public void NavigationBarTestUnregistered()
        {
            var loginPageInstance = LoginPage.NavigateTo(base.Driver);

            //loginPageInstance.UserNameTextBox.SendKeys(GeneralSettings.Default.UserName);
            //loginPageInstance.PasswordTextBox.SendKeys(GeneralSettings.Default.Password);

           // loginPageInstance.ValidLogIn();

            var loginPage = PageFactoryExtensions.InitPage<LoginPage>(this.Driver);

            Thread.Sleep(5000);

            //Assert.AreEqual(yourAccountPage.UserNameTextBox.Text, "FranzFischbach");


            Assert.Multiple(() =>
            {
                Assert.AreEqual("All Products", loginPage.AllProductButton.Text, "All Products");
                Assert.AreEqual("Home", loginPage.HomeButton.Text, "Home");
                Assert.AreEqual("Product Category", loginPage.ProductCategoryPage.Text, "Product Category");
                Assert.AreEqual("Services & Support", loginPage.ServicesSupportButton.Text, "Services & Support");
                Assert.AreEqual("My Account", loginPage.MyAccountButton.Text, "My Account");
                Assert.AreEqual(true, loginPage.LoginButton.Displayed, "LoginButton is displayed");
                Assert.AreEqual(true, loginPage.AllProductButton.Displayed, "All Products is displayed");
                Assert.AreEqual(true, loginPage.HomeButton.Displayed, "Home");
                Assert.AreEqual(true, loginPage.ProductCategoryPage.Displayed, "Product Category is displayed");
                Assert.AreEqual(true, loginPage.ServicesSupportButton.Displayed, "Services & Support is displayed");
                Assert.AreEqual(true, loginPage.MyAccountButton.Displayed, "My Account is displayed");

            });

        }

        [Test]
        [Category("Use case tests")]
        public void NavigationBarTestRegistered()
        {
            var loginPageInstance = LoginPage.NavigateTo(base.Driver);

            //loginPageInstance.UserNameTextBox.SendKeys(GeneralSettings.Default.UserName);
            //loginPageInstance.PasswordTextBox.SendKeys(GeneralSettings.Default.Password);

            loginPageInstance.ValidLogIn();


            var yourAccountPage = PageFactoryExtensions.InitPage<YourAccountPage>(this.Driver);

            Thread.Sleep(10000);

            //Assert.AreEqual(yourAccountPage.UserNameTextBox.Text, "FranzFischbach");


            Assert.Multiple(() =>
            {
                Assert.AreEqual("All Products", yourAccountPage.AllProductButton.Text, "All Products");
                Assert.AreEqual("Home", yourAccountPage.HomeButton.Text, "Home");
                Assert.AreEqual("Product Category", yourAccountPage.ProductCategoryPage.Text, "Product Category");
                Assert.AreEqual("Services & Support", yourAccountPage.ServicesSupportButton.Text, "Services & Support");
                Assert.AreEqual("Account\r\nMy Account", yourAccountPage.MyAccountButton.Text, "My Account");
                Assert.AreEqual("(Logout)", yourAccountPage.LogoutButton.Text, "Logout");
                Assert.AreEqual(true, yourAccountPage.AllProductButton.Displayed, "All Products is displayed");
                Assert.AreEqual(true, yourAccountPage.HomeButton.Displayed, "Home");
                Assert.AreEqual(true, yourAccountPage.ProductCategoryPage.Displayed, "Product Category is displayed");
                Assert.AreEqual(true, yourAccountPage.ServicesSupportButton.Displayed, "Services & Support is displayed");
                Assert.AreEqual(true, yourAccountPage.MyAccountButton.Displayed, "My Account is displayed");
                Assert.AreEqual(true, yourAccountPage.LogoutButton.Displayed, "Logout");



            });

        }
    }
}
