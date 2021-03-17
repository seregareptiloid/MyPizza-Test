using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizzaTest.Pages
{
   abstract class Page
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public Page(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        }
    }
}
