using System;
namespace Translation
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Input string:");
                    string str = Console.ReadLine();
                    Transliteration transliteration = new Transliteration();
                    transliteration.CheckString(str);
                    Console.WriteLine(transliteration.TranslateString(str));
                    break;
                }
                catch(StringException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
