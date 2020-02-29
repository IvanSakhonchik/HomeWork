using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using CalculatorRu;

namespace CalkulyatorRuTest
{
    [TestClass]
    public class CalculatorTest
    {
        const string url = "https://calkulyator.ru/";
        [TestMethod]
        public void PlusTestPositive()
        {
            TestInvoker testInvoker = new TestInvoker();
            string actualResult = testInvoker.GetResult("3+5=");
            Assert.Equals(actualResult, "8");
        }

        [TestMethod]
        public void MinusTestPositive()
        {
            TestInvoker testInvoker = new TestInvoker();
            string actualResult = testInvoker.GetResult("5-3=");
            Assert.Equals(actualResult, "2");
        }
        [TestMethod]
        public void MultiplyTestPositive()
        {
            TestInvoker testInvoker = new TestInvoker();
            string actualResult = testInvoker.GetResult("2*3=");
            Assert.Equals(actualResult, "6");
        }
        [TestMethod]
        public void DivisionTestPositive()
        {
            TestInvoker testInvoker = new TestInvoker();
            string actualResult = testInvoker.GetResult("6/3=");
            Assert.Equals(actualResult, "2");
        }
    }
}
