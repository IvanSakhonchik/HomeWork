using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace CalculatorRu
{
    public class TestInvoker
    {
        const string url = "https://calkulyator.ru/";
        public string GetResult(string buttonSequence)
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl(url);

            Dictionary<string, IWebElement> buttons = new Dictionary<string, IWebElement>();
            CalkulyatorRuPage calkulyator = new CalkulyatorRuPage(webDriver, buttons);

            List<string> buttonNames = ParseToList(buttonSequence);

            foreach (var buttonName in buttonNames)
            {
                calkulyator.Buttons[buttonName].Click();

            }
            return calkulyator.Buttons["display"].Text;

        }

        List<string> ParseToList(string str)
        {
            List<string> list_string = new List<string>();
            foreach(var element in str)
            {
                list_string.Add(element.ToString());
            }
            return list_string;
        }
    }
}
