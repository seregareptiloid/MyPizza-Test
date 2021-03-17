using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaTest.Pages
{
    class PizzaSelectionPage : Page
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

        public bool IsOnThePage()
        {
            return driver.FindElements(By.XPath("//h1[text()='Пицца 40см']")).Count > 0;
        }
        
        public PizzaSelectionPage AddPizzaQuantity(IWebElement PizzaAdditionArrow)
        {
            PizzaAdditionArrow.Click();
            return this;
        }




        public IWebElement Pizzacat => driver.FindElement(By.XPath("//div[text()='Пицца 40см']"));
        public IWebElement Italianpizza => driver.FindElement(By.XPath("public IWebElement"));
        public IWebElement arwAddVillagePizza => driver.FindElement(By.CssSelector("div:nth-child(5) span.c-menu__arrow.c-menu__arrow--plus.btn-increase"));

        public IWebElement arwAddGreekPizza => driver.FindElement(By.CssSelector("div:nth-child(7) span.c-menu__arrow.c-menu__arrow--plus.btn-increase"));

    }
}
