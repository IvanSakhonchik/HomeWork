using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersNS
{
    public class MaxCharacters
    {
        public MaxCharacters() { }

        public int GetMaxCountDifferentCharacters(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                throw new Exception();
            }
            inputString.ToLower();
            int currentMaxUnequalCharacters = 1;
            int maxUnequalCharacters = 1;
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i] != inputString[i + 1])
                {
                    currentMaxUnequalCharacters++;
                }
                else if (currentMaxUnequalCharacters > maxUnequalCharacters)
                {
                    maxUnequalCharacters = currentMaxUnequalCharacters;
                    currentMaxUnequalCharacters = 1;
                }
                else if (currentMaxUnequalCharacters <= maxUnequalCharacters)
                {
                    currentMaxUnequalCharacters = 1;
                }

            }
            if (currentMaxUnequalCharacters > maxUnequalCharacters)
            {
                maxUnequalCharacters = currentMaxUnequalCharacters;
            }
            return maxUnequalCharacters;
        }

        public int GetMaxCountSameNumbers(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                throw new Exception();
            }
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] < '0' || inputString[i] > '9')
                {
                    throw new InvalidStringException("Invalid format");
                }
            }
            int currentMaxCountSameNumbers = 1;
            int maxCountSameNumbers = 1;
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i] == inputString[i + 1])
                {
                    currentMaxCountSameNumbers++;
                }
                else if (currentMaxCountSameNumbers > maxCountSameNumbers)
                {
                    maxCountSameNumbers = currentMaxCountSameNumbers;
                    currentMaxCountSameNumbers = 1;
                }
                else if (currentMaxCountSameNumbers <= maxCountSameNumbers)
                {
                    currentMaxCountSameNumbers = 1;
                }

            }
            if (currentMaxCountSameNumbers > maxCountSameNumbers)
            {
                maxCountSameNumbers = currentMaxCountSameNumbers;
            }
            return maxCountSameNumbers;
        }

        public int GetMaxCountSameLatinLetters(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                throw new Exception();
            }
            inputString.ToLower();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] < 'a' || inputString[i] > 'z')
                {
                    throw new InvalidStringException("Invalid formatr");
                }
            }
            int currentMaxCountSameLatinLetters = 1;
            int maxCountSameLatinLetters = 1;
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i] == inputString[i + 1])
                {
                    currentMaxCountSameLatinLetters++;
                }
                else if (currentMaxCountSameLatinLetters > maxCountSameLatinLetters)
                {
                    maxCountSameLatinLetters = currentMaxCountSameLatinLetters;
                    currentMaxCountSameLatinLetters = 1;
                }
                else if (currentMaxCountSameLatinLetters <= maxCountSameLatinLetters)
                {
                    currentMaxCountSameLatinLetters = 1;
                }

            }
            if (currentMaxCountSameLatinLetters > maxCountSameLatinLetters)
            {
                maxCountSameLatinLetters = currentMaxCountSameLatinLetters;
            }
            return maxCountSameLatinLetters;
        }
    }
}
