using System;
using System.Collections.Generic;
using System.Text;
using MyPizzaTest.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace MyPizzaTest.Pages
{
   public class CartPage : Page
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
        }

        public void FillCartFields(User user)
        {
            txtName.SendKeys(user.Name);
            txtPhoneNumber.SendKeys(user.Phone);
            txtHouse.SendKeys(user.Home);
            txtApartments.SendKeys(user.Appartments);
            txtEntry.SendKeys(user.Entry);
            txtFloor.SendKeys(user.Floor);
            txtEntryCode.SendKeys(user.EntryCode);
            txtComment.SendKeys(user.Comment);
        }
        public void MakeScreenShot()
        {


            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C://Image.png",
            ScreenshotImageFormat.Png);
        }
        public bool IsOnThePage() => driver.FindElements(By.XPath("//h1[text()='Заказ']")).Count > 0;

        IWebElement txtName => driver.FindElement(By.XPath("//*[@id=\"cartOrderId\"]/form/div[2]/input"));
        IWebElement txtPhoneNumber => driver.FindElement(By.Id("phone"));
        IWebElement ddlStreet => driver.FindElement(By.CssSelector("//*[@id=\"tab-delivery\"]/div[3]/div[1]/input"));
        IWebElement txtHouse => driver.FindElement(By.CssSelector("[data-bind=\"value: House\"]"));
        IWebElement txtApartments => driver.FindElement(By.CssSelector("[data-bind=\"value: Apartments\"]"));
        IWebElement txtFloor => driver.FindElement(By.CssSelector("#tab-delivery > div:nth-child(4) > div:nth-child(3) > input[type=text]"));
        IWebElement txtEntry => driver.FindElement(By.CssSelector("[data-bind=\"value: Entry\"]"));
        IWebElement txtEntryCode => driver.FindElement(By.CssSelector("[data-bind=\"value: EntryCode\"]"));
        IWebElement ddlHours => driver.FindElement(By.CssSelector("[data-bind=\"options: Hours(),value: Hour\"]"));
        IWebElement ddlMinutes => driver.FindElement(By.CssSelector("[data-bind=\"options: Minutes(),value: Minute\"]"));
        IWebElement txtComment => driver.FindElement(By.CssSelector("[data-bind=\"value: Comment\"]"));

    }
}
