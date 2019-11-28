using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            PageGmailCom pageGmailCom = new PageGmailCom();
            pageGmailCom.InputForMail();
            pageGmailCom.SendMessage();
            pageGmailCom.Quit();

            PageMailRu pageMailRu = new PageMailRu();
            pageMailRu.InputForMail();
            pageMailRu.ReadMessage();
            pageMailRu.Quit();

        }
    }
}
