using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HW5
{
    class PageGmailCom
    {
        IWebDriver browser = new ChromeDriver();
        public void InputForMail()
        {

            browser.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");

            IWebElement login = GetElement(By.Id("identifierId"), browser);
            login.SendKeys("trainingwebdriver" + Keys.Enter);

            IWebElement password = GetElement(By.Name("password"), browser);
            password.SendKeys("Asdfghjk321" + Keys.Enter);

        }

        public void SendMessage()
        {
            IWebElement buttonWrite = GetElement(By.XPath("//div[@class='T-I J-J5-Ji T-I-KE L3']"), browser);
            buttonWrite.Click();

            IWebElement mail = GetElement(By.ClassName("vO"), browser);
            mail.SendKeys("accountforwebdriver@mail.ru");

            IWebElement topic = browser.FindElement(By.Id(":8u"));
            topic.SendKeys("Bot");

            IWebElement message = browser.FindElement(By.Id(":9z"));
            message.SendKeys(DateTime.Now.ToString());

            IWebElement buttonSendMessage = browser.FindElement(By.Id(":8k"));
            buttonSendMessage.Click();
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
