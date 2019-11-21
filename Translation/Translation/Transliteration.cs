
namespace Translation
{
    public class Transliteration
    {
        const string RUSSIAN = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        const string LATIN = " abvgdeyozhiklmnprstufhc";
        public Transliteration() { }

        // This method checks the string for validity
        public void CheckString(string str)
        {
            str = str.ToLower();
            string russianСonsonants = "бвгджзклмнпрстфхцчшщ";
            int counterRussianSymbols = 0;
            int counterLatinSymbols = 0;

            if (str.Length == 0 || str == null)
            {
                throw new StringException("Empty String. Try again");
            }


            foreach (char symbol in str)
            {
                if (RUSSIAN.Contains(symbol) == false && LATIN.Contains(symbol) == false)
                {
                    throw new StringException("Invalid characters. Try again");
                }
                if (RUSSIAN.Contains(symbol))
                {
                    if (str[0] == 'ь' || str[0] == 'ъ') // 'ь' and 'ъ' cannot be at the beginning of the string
                    {
                        throw new StringException("Invalid characters. Try again");
                    }
                    for (int i = 1; i < str.Length; i++)
                    {
                        if ((str[i] == 'ь' && russianСonsonants.Contains(str[i - 1]) == false) || (str[i] == 'ъ' && russianСonsonants.Contains(str[i - 1]) == false)) // before 'ь' and 'ъ' can be only consonants
                        {
                            throw new StringException("Invalid characters. Try again");
                        }
                    }
                    counterRussianSymbols++;
                }
                if (LATIN.Contains(symbol))
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if(str[i] == 'c' && str[i + 1] != 'h') // ч - ch, 'c' is not used anywhere 
                        {
                            throw new StringException("Invalid characters. Try again");
                        }
                    }
                        counterLatinSymbols++;
                }
                if (counterRussianSymbols > 0 && counterLatinSymbols > 0)
                {
                    throw new StringException("Invalid characters. Try again");
                }
            }
        }

        //This method translates the russian string to latin and vice versa
        public string TranslateString(string str)
        {
            string str_checker = str.ToLower();
            string[] latinUpper = { "Yu", "Ya","A", "B", "V", "G", "D", "E", "Yo", "Zh", "Z", "I", "L", "M", "N", "O", "P",
                                    "R", "U", "F", "Kh", "Ts", "Sch", "Ch", "Sh", "-", "-", "E",  "Y", "Y", "K", "T", "S" };
            string[] latinLow = { "yu", "ya","a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "l", "m", "n", "o", "p",
                                  "r", "u", "f", "kh", "ts", "sch", "ch", "sh", "-", "-", "e",  "y", "y", "k", "t", "s" };
            string[] russianUpper = { "Ю", "Я","А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Л", "М", "Н", "О", "П",
                                      "Р", "У", "Ф", "Х", "Ц", "Щ", "Ч", "Ш", "Ъ", "Ь", "Э",  "Й", "Ы", "К", "Т", "С" };
            string[] russsianLow = { "ю", "я","а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "л", "м", "н", "о", "п",
                                     "р", "у", "ф", "х", "ц", "щ", "ч", "ш", "ъ", "ь", "э",  "й", "ы", "к", "т", "с"};
            foreach (char symbol in str_checker)
            {
                if (RUSSIAN.Contains(symbol))
                {
                    for (int i = 0; i < latinUpper.Length; i++)
                    {
                        if (i == 25 || i == 26) // because str[25]-'ь' str[26]-'ъ' - this characters disappear during translation 
                        {
                            str = str.Replace(russianUpper[i], "");
                            str = str.Replace(russsianLow[i], "");
                        }
                        else
                        {
                            str = str.Replace(russianUpper[i], latinUpper[i]);
                            str = str.Replace(russsianLow[i], latinLow[i]);
                        }
                    }
                }
                else if (LATIN.Contains(symbol))
                {
                    for (int i = 0; i < latinUpper.Length; i++)
                    {
                        str = str.Replace(latinUpper[i], russianUpper[i]);
                        str = str.Replace(latinLow[i], russsianLow[i]);
                    }
                }
            }
            return str;
        }
    }
}
