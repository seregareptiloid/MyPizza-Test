using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaTest.Pages
{
    class PizzaConstructorObject : Page
    {
        public PizzaConstructorObject(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public bool IsOnThePage()
        {
            return driver.FindElements(By.XPath("//a[text()='В корзину']")).Count > 0;
        }

        public void AddToCart(int quantity)
        {
            arwAddQuantity.Click();
            btnAddToCart.Click();
        }


        IWebElement btnAddToCart => driver.FindElement(By.XPath("//a[text()='В корзину']"));
        IWebElement arwAddQuantity => driver.FindElement(By.CssSelector("#modal  span.c-menu__arrow.c-menu__arrow--plus"));



    }
}
