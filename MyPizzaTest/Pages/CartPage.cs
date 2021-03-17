using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace MyPizzaTest.Pages
{
    class CartPage : Page
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

       

        #region Selectors
        IWebElement txtName => driver.FindElement(By.CssSelector("[data-bind=\"value: LastName\"]"));
        IWebElement txtPhoneNumber => driver.FindElement(By.Id("phone"));
        IWebElement ddlStreet => driver.FindElement(By.CssSelector("[id=tab-delivery] [class=select2-selection__rendered]"));
        IWebElement txtHouse => driver.FindElement(By.CssSelector("[data-bind=\"value: House\"]"));
        IWebElement txtBuilding => driver.FindElement(By.CssSelector("[data-bind=\"value: Building\"] "));
        IWebElement txtApartments => driver.FindElement(By.CssSelector(" [for=Apartments]"));
        IWebElement txtFloor => driver.FindElement(By.CssSelector(" [for=Floor]"));
        IWebElement txtEntry => driver.FindElement(By.CssSelector(" [for=Entry]"));
        IWebElement txtEntryCode => driver.FindElement(By.CssSelector(" [for=EntryCode]"));
        IWebElement ddlHours => driver.FindElement(By.CssSelector("[data-bind=\"options: Hours(),value: Hour\"]"));
        IWebElement ddlMinutes => driver.FindElement(By.CssSelector("[data-bind=\"options: Minutes(),value: Minute\"]"));
        IWebElement txtComment => driver.FindElement(By.CssSelector("[data-bind=\"value: Comment\"]"));
        IWebElement txtChangeSum => driver.FindElement(By.CssSelector("[value:ChangeSum]"));
        IWebElement chkOrderAgree => driver.FindElement(By.Id("order-agreement-agree"));
        #endregion

    }
}
