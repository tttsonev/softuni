using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverTemplateProject.Pages
{
    class YourAccountPage : Page
    {
        [FindsBy(How = How.Id, Using = "menu-item-15")]
        public IWebElement HomeButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-33")]
        public IWebElement ProductCategoryPage { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-72")]
        public IWebElement AllProductButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-16")]
        public IWebElement ServicesSupportButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account a")]
        public IWebElement MyAccountButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "display-name")]
        public IWebElement UserNameTextBox { get; set; }

        [FindsBy(How = How.LinkText, Using = "(Logout)")]
        public IWebElement LogoutButton { get; set; }

        public static YourAccountPage NavigateTo(IWebDriver driver)
        {
            var loginPageInstance = LoginPage.NavigateTo(driver);
            loginPageInstance.ValidLogIn();

            var yourAccountPageInstance = PageFactoryExtensions.InitPage<YourAccountPage>(driver);

            return yourAccountPageInstance;
        }
    }
}
