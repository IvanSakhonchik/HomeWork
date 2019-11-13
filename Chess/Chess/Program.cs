﻿using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    //Create the first cell
                    string str1 = Console.ReadLine();
                    CheckString(str1);
                    Cell cell1 = new Cell(str1);
                    Console.WriteLine(CheckColour(cell1));

                    //Create the second cell
                    string str2 = Console.ReadLine();
                    CheckString(str2);
                    Cell cell2 = new Cell(str2);
                    Console.WriteLine(CheckColour(cell2));

                    //Cell comparison
                    Console.WriteLine(ComparisonLocation(cell1, cell2));
                    break;
                }
                catch (NotStringException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
  
        }

        //Checking the string for size and value
        public static void CheckString(string str)
        {
            string symbols = "abcdefgh";
            string numbers = "12345678";
            str.ToLower();
            if (str.Length == 2)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (symbols.Contains(str[0]) && numbers.Contains(str[1]))
                    {
                    }
                    else
                    {
                        throw new NotStringException("Invalid characters. Try again");
                    }
                }
            }
            else
            {
                throw new NotStringException("Not enough or many characters. Try again");
            }

        }

        //Check cell for color
        public static string CheckColour(Cell cell)
        {
            if ((cell.File + cell.Rank) % 2 == 0)
            {
                return "Black";
            }
            else return "White";
        }

        //Finding and comparing cells vertically, horizontally, diagonally
        public static string ComparisonLocation(Cell cell1, Cell cell2)
        {
            if(cell1.Equals(cell2))
            {
                return "The cells are the same ";
            }
            if (cell1.File == cell2.File)
            {
                return "Cells are on the same vertical.";
            }
            if (cell1.Rank == cell2.Rank)
            {
                return "Cells are on the same horizontal.";
            }
            if (Math.Abs(cell1.File - cell2.File) == Math.Abs(cell1.Rank - cell2.Rank))
            {
                return "Cells are on the same diagonal.";
            }
            else return "Cells are independent of each other.";
        }

    }
}
