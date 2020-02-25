using System;

namespace CharactersNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a string, and then press Enter: ");
            string inputString = Console.ReadLine();
            MaxCharacters maxCharacters = new MaxCharacters();
            try
            {
                Console.WriteLine(maxCharacters.GetMaxCountSameLatinLetters(inputString));
                Console.WriteLine(maxCharacters.GetMaxCountSameNumbers(inputString));
                Console.WriteLine(maxCharacters.GetMaxCountDifferentCharacters(inputString));
            }
            catch (InvalidStringException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

