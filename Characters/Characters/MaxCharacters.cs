using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersNS
{
    public class MaxCharacters
    {
        public MaxCharacters() { }

        public int GetMaxCountDiffrentCharacters(string str)
        {
            if (str.Length == 0)
            {
                throw new Exception();
            }
            str.ToLower();
            int counter = 1;
            int maxCounter = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    counter++;
                }
                else if (counter > maxCounter)
                {
                    maxCounter = counter;
                    counter = 1;
                }
                else if (counter <= maxCounter)
                {
                    counter = 1;
                }

            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
            }
            return maxCounter;
        }

        public int GetMaxCountSameNumbers(string str)
        {
            if (str.Length == 0)
            {
                throw new Exception();
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                {
                    throw new InvalidStringException("Invalid format");
                }
            }
            int counter = 1;
            int maxCounter = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    counter++;
                }
                else if (counter > maxCounter)
                {
                    maxCounter = counter;
                    counter = 1;
                }
                else if (counter <= maxCounter)
                {
                    counter = 1;
                }

            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
            }
            return maxCounter;
        }

        public int GetMaxCountSameLatinLetters(string str)
        {
            if (str.Length == 0)
            {
                throw new Exception();
            }
            str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 'a' || str[i] > 'z')
                {
                    throw new InvalidStringException("Invalid format");
                }
            }
            int counter = 1;
            int maxCounter = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    counter++;
                }
                else if (counter > maxCounter)
                {
                    maxCounter = counter;
                    counter = 1;
                }
                else if (counter <= maxCounter)
                {
                    counter = 1;
                }

            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
            }
            return maxCounter;
        }
    }
}
