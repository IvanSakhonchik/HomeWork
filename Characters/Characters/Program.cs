using System;

namespace CharactersNS
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            MaxCharacters maxCharacters = new MaxCharacters();
            try
            {
                Console.WriteLine(maxCharacters.GetMaxCountSameLatinLetters(str));
                Console.WriteLine(maxCharacters.GetMaxCountSameNumbers(str));
                Console.WriteLine(maxCharacters.GetMaxCountDiffrentCharacters(str));
            }
            catch (InvalidStringException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

