using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharactersNS;

namespace SymbolTest
{
    [TestClass]
    public class CharactersTests
    {
        //GetMaxCountDiffrentCharacters
        [TestMethod]
        public void InputEmptyStringInSameCharacters()
        {
            string str = "";
            MaxCharacters maxCharacters = new MaxCharacters();
            Assert.ThrowsException<System.Exception>(() => maxCharacters.GetMaxCountDiffrentCharacters(str));
        }

        [TestMethod]
        public void InputStringWithValidValue()
        {
            string str = "abcd";
            int expected = 4;
            MaxCharacters maxCharacters = new MaxCharacters();
            int actual = maxCharacters.GetMaxCountDiffrentCharacters(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }

        [TestMethod]
        public void InputStringWithFirstSameValue()
        {
            string str = "aaabcd";
            int expected = 4;
            MaxCharacters maxCharacters = new MaxCharacters();
            int actual = maxCharacters.GetMaxCountDiffrentCharacters(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }

        [TestMethod]
        public void InputStringWithMiddleSameValue()
        {
            string str = "abbbcd";
            int expected = 3;
            MaxCharacters maxCharacters = new MaxCharacters();
            int actual = maxCharacters.GetMaxCountDiffrentCharacters(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }

        [TestMethod]
        public void InputStringWithLastSameValue()
        {
            string str = "aaabcddd";
            int expected = 4;
            MaxCharacters maxCharacters = new MaxCharacters();
            int actual = maxCharacters.GetMaxCountDiffrentCharacters(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }

        //GetMaxCountSameNumbers
        [TestMethod]
        public void InputEmptyStringInSameNumbers()
        {
            string str = "";
            MaxCharacters maxCharacters = new MaxCharacters();
            Assert.ThrowsException<System.Exception>(() => maxCharacters.GetMaxCountSameNumbers(str));
        }
        [TestMethod]
        public void InputStringNumbersWithInvalidValue()
        {
            string str = "abcd";
            MaxCharacters maxCharacters = new MaxCharacters();
            Assert.ThrowsException<InvalidStringException>(() => maxCharacters.GetMaxCountSameNumbers(str));
        }

        [TestMethod]
        public void InputStringNumbersWithFirstSameValue()
        {
            string str = "111234";
            int expected = 3;
            MaxCharacters maxCharacters = new MaxCharacters();
            int actual = maxCharacters.GetMaxCountSameNumbers(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }

        [TestMethod]
        public void InputStringNumbersWithMiddleSameValue()
        {
            string str = "122234";
            int expected = 3;
            MaxCharacters maxCharacters = new MaxCharacters();
            int actual = maxCharacters.GetMaxCountSameNumbers(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }

        [TestMethod]
        public void InputStringNumbersWithLastSameValue()
        {
            string str = "123444";
            int expected = 3;
            MaxCharacters maxCharacters = new MaxCharacters();
            int actual = maxCharacters.GetMaxCountSameNumbers(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }

        //GetMaxCountSameLatinLetters
        [TestMethod]
        public void InputEmptyStringInSameLatinLetters()
        {
            string str = "";
            MaxCharacters maxCharacters = new MaxCharacters();
            Assert.ThrowsException<System.Exception>(() => maxCharacters.GetMaxCountSameLatinLetters(str));
        }

        [TestMethod]
        public void InputStringLettersWithInvalidValue()
        {
            string str = "1234";
            MaxCharacters maxCharacters = new MaxCharacters();
            Assert.ThrowsException<InvalidStringException>(() => maxCharacters.GetMaxCountSameLatinLetters(str));
        }

        [TestMethod]
        public void InputStringLettersWithFirstSameValue()
        {
            string str = "aaabcd";
            int expected = 3;
            MaxCharacters maxCharacters = new MaxCharacters();
            int actual = maxCharacters.GetMaxCountSameLatinLetters(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }

        [TestMethod]
        public void InputStringLettersWithMiddleSameValue()
        {
            string str = "abbbcd";
            int expected = 3;
            MaxCharacters maxCharacters = new MaxCharacters();
            int actual = maxCharacters.GetMaxCountSameLatinLetters(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }

        [TestMethod]
        public void InputStringLettersWithLastSameValue()
        {
            string str = "abcddd";
            int expected = 3;
            MaxCharacters maxCharacters = new MaxCharacters();
            int actual = maxCharacters.GetMaxCountSameLatinLetters(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }
    }
}
