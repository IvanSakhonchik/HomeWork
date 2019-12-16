using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace CalculatorRu
{
    public class CalkulyatorRuPage:PageObject
    {
        public CalkulyatorRuPage(IWebDriver driver, Dictionary<string, IWebElement> buttons):base(driver, buttons)
        {
            buttons.Add("display",GetElement(By.Id("display")));
            buttons.Add("1", GetElement(By.XPath("//td[text()='1']")));
            buttons.Add("2", GetElement(By.XPath("//td[text()='2']")));
            buttons.Add("3", GetElement(By.XPath("//td[text()='3']")));
            buttons.Add("4", GetElement(By.XPath("//td[text()='4']")));
            buttons.Add("5", GetElement(By.XPath("//td[text()='5']")));
            buttons.Add("6", GetElement(By.XPath("//td[text()='6']")));
            buttons.Add("7", GetElement(By.XPath("//td[text()='7']")));
            buttons.Add("8", GetElement(By.XPath("//td[text()='8']")));
            buttons.Add("9", GetElement(By.XPath("//td[text()='9']")));
            buttons.Add("0", GetElement(By.XPath("//td[text()='0']")));
            buttons.Add("00", GetElement(By.XPath("//td[text()='00']")));
            buttons.Add("+", GetElement(By.XPath("//td[text()='+']")));
            buttons.Add("-", GetElement(By.XPath("//td[text()='-']")));
            buttons.Add("*", GetElement(By.XPath("//td[text()='X']")));
            buttons.Add("=", GetElement(By.XPath("//td[text()='=']")));
            buttons.Add("/", GetElement(By.XPath("//td[text()='÷']")));
            buttons.Add("%", GetElement(By.XPath("//td[text()='%']")));
            buttons.Add("^", GetElement(By.XPath("//sup[text()='ʸ']")));
            buttons.Add("sqrt", GetElement(By.XPath("//td[text()='√']")));
            buttons.Add("M-", GetElement(By.XPath("//td[text()='M-']")));
            buttons.Add("M+", GetElement(By.XPath("//td[text()='M+']")));
            buttons.Add("MR", GetElement(By.XPath("//td[text()='MR']")));
            buttons.Add("MC", GetElement(By.XPath("//td[text()='MC']")));
            buttons.Add("00>0", GetElement(By.XPath("//td[text()='00￫0']")));
            buttons.Add("+/-", GetElement(By.XPath("//td[text()='+/-']")));
            buttons.Add("AC", GetElement(By.XPath("//td[text()='AC']")));
            buttons.Add("C", GetElement(By.XPath("//td[text()='C']")));
            buttons.Add(".", GetElement(By.XPath("//td[text()='.']")));

        }
        
    }
}
