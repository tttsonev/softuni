﻿using OpenQA.Selenium;
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
    public class ProductContainer
    {
        public IWebElement Root { get; set; }

        public ProductContainer(IWebElement root)
        {
            this.Root = root;
        }

        public IWebElement PriceTextBox
        {
            get
            {
                return this.Root.FindElement(By.Name("Buy"));
            }
        }

        public IWebElement ProductTitleTextBox
        {
            get
            {
                return this.Root.FindElement(By.ClassName("wpsc_product_title"));
            }
        }

        public IWebElement AddToCartButton
        {
            get
            {
                return this.Root.FindElement(By.ClassName("wpsc_buy_button"));
            }
        }
    }

    public class ProductCategoryPage : Page
    {
        [FindsBy(How = How.LinkText, Using = "Home")]
        public IWebElement HomeButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "Product Category")]
        public IWebElement ProductCategoryButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "All Product")]
        public IWebElement AllProductButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account a")]
        public IWebElement MyAccountButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "entry-content")]
        public IWebElement ProductsContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "count")]
        public IWebElement ProductCountTextBox { get; set; }

        public static ProductCategoryPage NavigateTo(IWebDriver driver)
        {
            var homePageInstance = HomePage.NavigateTo(driver);

            homePageInstance.ProductCategoryButton.Click();

            return PageFactoryExtensions.InitPage<ProductCategoryPage>(driver);
        }

        public List<ProductContainer> GetProducts()
        {
            var roots = this.ProductsContainer.FindElements(By.ClassName("product-category"));

            List<ProductContainer> products = new List<ProductContainer>();

            foreach (var rootElement in roots)
            {
                products.Add(new ProductContainer(rootElement));
            }

            return products;
        }
    }
}
