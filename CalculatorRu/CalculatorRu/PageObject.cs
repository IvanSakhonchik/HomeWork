using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CalculatorRu
{
    public class PageObject
    {
        public Dictionary<string, IWebElement> Buttons { get; set; } = new Dictionary<string, IWebElement>();
        protected IWebDriver Driver { get; set; }
        public PageObject(IWebDriver driver, Dictionary<string, IWebElement> buttons)
        {
            Buttons = buttons;
            Driver = driver;
        }
        public IWebElement GetElement(By elementLocator)
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(elementLocator));
        }
    }
}
