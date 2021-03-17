using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using MyPizzaTest.Pages;
using FluentAssertions;
using NUnit.Framework;
using MyPizzaTest.Model;

namespace SpecFlowMyPizzaTest.Spec.Steps
{
    [Binding]
    public class PizzaOrderStepDefinitions
    {
        static IWebDriver driver = new ChromeDriver();
        PizzaSelectionPage pizzaSelectionPage = new PizzaSelectionPage(driver);
        PizzaConstructorObject pizzaConstructorObject;
        CartPage cartPage;
        User user = new User();


        [Given(@"pizza category is on the page")]
        public void GivenPizzaCategoryIsOnThePage()
        {
            pizzaSelectionPage.Open().GoToPizzaCategory();
        }

        [When(@"user order products")]
        public void WhenUserOrderProducts()
        {
            pizzaSelectionPage.AddPizza(pizzaSelectionPage.ArrowAddVillagePizza);
            pizzaSelectionPage.AddPizza(pizzaSelectionPage.ArrowAddGreekPizza);
             pizzaSelectionPage.SelectPizza(pizzaSelectionPage.Italianpizza).AddToCart();
        }


        [When(@"user opens Cart Page")]
        public void WhenUserClicksCheckoutButton()
        {
            cartPage = pizzaSelectionPage.Checkout();
        }


        [When(@"fields are filled")]
        public void WhenFielsAreFilled()
        {
            cartPage.FillCartFields(user);
        }

        [When(@"screenshot is made")]
        public void WhenScreenshotIsMade()
        {
            cartPage.MakeScreenShot();
        }

        [Then(@"Cart page should be opened")]
        public void ThenCartPageShouldBeOpened()
        {
            cartPage.IsOnThePage().Should().BeTrue();
        }
    }
}
