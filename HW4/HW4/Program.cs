using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args) 
        {
            IWebDriver browser = new ChromeDriver();
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl("https://mail.ru");

            IWebElement login_input = browser.FindElement(By.Id("mailbox:login"));
            login_input.SendKeys("accountforwebdriver" + Keys.Enter);

            IWebElement password_input = new WebDriverWait(browser, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.Id("mailbox:password")));
            password_input.SendKeys("Asdfghjk543" + Keys.Enter);

            IWebElement count_message = new WebDriverWait(browser, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.Id("g_mail_events")));
            Console.Write("The number of unread messages: " + count_message.Text);

            browser.Quit();
        }
    }
}
