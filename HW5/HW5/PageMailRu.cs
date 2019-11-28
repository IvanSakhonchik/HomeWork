using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HW5
{
    class PageMailRu
    {
        IWebDriver browser = new ChromeDriver();
        public void InputForMail()
        {

            browser.Navigate().GoToUrl("https://mail.ru");

            IWebElement login = GetElement(By.Id("mailbox:login"), browser);
            login.SendKeys("accountforwebdriver" + Keys.Enter);

            IWebElement password = GetElement(By.Id("mailbox:password"), browser);
            password.SendKeys("Asdfghjk543" + Keys.Enter);

        }
        //public void SendMessage()
        //{
        //    IWebElement buttonWrite = GetElement(By.ClassName("compose-button__txt"), browser);
        //    buttonWrite.Click();
        //}

        public void ReadMessage()
        {
            IWebElement messageUnread = GetElement(By.XPath("//span[@title='Вася Пупкин <trainingwebdriver@gmail.com>']"),browser);
            messageUnread.Click();
        }

        public void Quit()
        {
            browser.Quit();
        }


        private IWebElement GetElement(By elementLocator, IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(elementLocator));
        }
    }
}
