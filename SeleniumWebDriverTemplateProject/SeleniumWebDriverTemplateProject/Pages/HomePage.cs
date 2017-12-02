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
    public class HomePage : Page
    {

        [FindsBy(How = How.LinkText, Using = "Home")]
        public IWebElement HomeButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "All Product")]
        public IWebElement AllProductButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account a")]
        public IWebElement MyAccountButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "#0 (no title)")]
        public IWebElement ServicesSupportButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "Product Category")]
        public IWebElement ProductCategoryButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "footer_blog")]
        public IWebElement LatestProducts { get; set; }

        [FindsBy(How = How.XPath, Using = "//section[contains(@class, 'footer_featured')]//li")]
        public IList<IWebElement> LatestProductsList { get; set; }

        [FindsBy(How = How.XPath, Using = "//section[contains(@class, 'footer_featured')]//li/a")]
        public IList<IWebElement> LatestProductsLinks { get; set; }





        public static HomePage NavigateTo(IWebDriver driver)
        {
            var yourAccountPageInstance = YourAccountPage.NavigateTo(driver);

            yourAccountPageInstance.HomeButton.Click();

            var homePageInstance = PageFactoryExtensions.InitPage<HomePage>(driver);

            return homePageInstance;
        }
    }
}
