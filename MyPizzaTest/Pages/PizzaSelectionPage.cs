using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaTest.Pages
{
    public class PizzaSelectionPage : Page
    {
        public PizzaSelectionPage(IWebDriver driver) : base(driver)
            {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        public PizzaSelectionPage Open()
        {
            driver.Url = "https://mypizza.kg/ ";
            return this;
        }
        
        public PizzaSelectionPage GoToPizzaCategory()
        {
            Pizzacat.Click();
            return this;
        }

        public bool IsOnThePage()
        {
            return driver.FindElements(By.XPath("//h1[text()='Пицца 40см']")).Count > 0;
        }
        
        public void AddPizza(IWebElement arrowPizza)
        {
            arrowPizza.Click();
        }

        public PizzaConstructorObject SelectPizza(IWebElement pizza)
        {
            pizza.Click();
            return new PizzaConstructorObject(driver);
        }

        public bool ItalianPizzaIsInTheCart() => driver.FindElements(By.CssSelector("[id=basket] [dataid=\"1018735\"]")).Count > 0;

        public bool GreecePizzaInTheCart() => driver.FindElements(By.CssSelector("[id=basket] [dataid=\"1032184\"]")).Count > 0;
        public CartPage Checkout()
        {
            btnCheckout.Click();
            return new CartPage(driver);
        }



        private IWebElement Pizzacat => driver.FindElement(By.XPath("//div[text()='Пицца 40см']"));
        public IWebElement Italianpizza => driver.FindElement(By.XPath("//a[text()='Итальянка 40см']"));
        public IWebElement ArrowAddVillagePizza => driver.FindElement(By.CssSelector("div:nth-child(5) span.c-menu__arrow.c-menu__arrow--plus.btn-increase"));

        public IWebElement ArrowAddGreekPizza => driver.FindElement(By.CssSelector("div:nth-child(7) span.c-menu__arrow.c-menu__arrow--plus.btn-increase"));
        private IWebElement btnCheckout => driver.FindElement(By.XPath("//a[text()='Оформить заказ']"));
    }
}
