using System;

namespace MaxUnequalCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = string.Empty;

            // Ask the user to type the string
            Console.WriteLine("Type a string, and then press Enter: ");
            bool validValue = false;
            while(!validValue)
            {
                inputString = Console.ReadLine(); 

                // Check string and replace
                if(string.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine("Invalid Value. Try again");
                }
                else validValue = true;
                
            }
            Console.WriteLine("Maximum number of unequal consecutive characters:{0}", GetMaxUnequalConsecutiveCharacters(inputString));

        }

        // This method consider maximum number of unequal consecutive characters
        static int GetMaxUnequalConsecutiveCharacters(string inputString)
        {
            // Declare variables
            int maxUnequalCharacters = 1;
            int currentMaxUnequalCharacters = 1;

            for(int i =0; i < inputString.Length-1; i++)
            {
                if (inputString[i] != inputString[i + 1])
                {
                    currentMaxUnequalCharacters++;
                }
                else
                {
                    if (currentMaxUnequalCharacters > maxUnequalCharacters)
                    {
                        maxUnequalCharacters = currentMaxUnequalCharacters;
                        currentMaxUnequalCharacters = 0;
                    }
                }
            }
            if (currentMaxUnequalCharacters > maxUnequalCharacters)
            {
                maxUnequalCharacters = currentMaxUnequalCharacters;
            }

            return maxUnequalCharacters;
        }
            
    }
}