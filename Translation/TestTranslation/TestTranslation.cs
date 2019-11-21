using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translation;
namespace TestTranslation
{
    [TestClass]
    public class TestTranslation
    {
        [TestMethod]
        public void InputEmptyStringNegative()
        {
            string str = "";
            Transliteration transliteration = new Transliteration();
            Assert.ThrowsException<StringException>(() => transliteration.CheckString(str));
        }

        [TestMethod]
        public void InputInvalidStringNegative()
        {
            string str = "Qwe";
            Transliteration transliteration = new Transliteration();
            Assert.ThrowsException<StringException>(() => transliteration.CheckString(str));
        }
        public void InputNextInvalidStringNegative()
        {
            string str = "',.[]";
            Transliteration transliteration = new Transliteration();
            Assert.ThrowsException<StringException>(() => transliteration.CheckString(str));
        }

        [TestMethod]
        public void InputLatinAndRussianNegative()
        {
            string str = "Asd���asd";
            Transliteration transliteration = new Transliteration();
            Assert.ThrowsException<StringException>(() => transliteration.CheckString(str));
        }
        [TestMethod]
        public void InputRussianInvalidCharactersNegative()
        {
            string str = "������";
            Transliteration transliteration = new Transliteration();
            Assert.ThrowsException<StringException>(() => transliteration.CheckString(str));
        }
        [TestMethod]
        public void InputNextRussianInvalidCharactersNegative()
        {
            string str = "������";
            Transliteration transliteration = new Transliteration();
            Assert.ThrowsException<StringException>(() => transliteration.CheckString(str));
        }
        [TestMethod]
        public void InputRussian�onsonantsValidCharactersPositive()
        {
            string str = "��������";
            string expected = "PshZl";
            Transliteration transliteration = new Transliteration();
            string actual = transliteration.TranslateString(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }

        [TestMethod]
        public void InputLatinWithValidValuePositive()
        {
            string str = "��������������������������������";
            string expected = "ABVGdeyozhziyklmnOPRStufkhtschshschyeyuya";
            Transliteration transliteration = new Transliteration();
            string actual = transliteration.TranslateString(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }
        [TestMethod]
        public void InputRussianWithValidValuePositive()
        {
            string str = "ABVGdeyozhziyklmnOPRStufkhtschshschyeyuya";
            string expected = "������������������������������";
            Transliteration transliteration = new Transliteration();
            string actual = transliteration.TranslateString(str);
            Assert.AreEqual(expected, actual, "Does not converge");
        }
    }
}
