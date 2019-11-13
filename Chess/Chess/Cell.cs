using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class Cell
    {
        public int File { get; }
        public int Rank { get; }
        public Cell(string str)
        {
            File = TransferFile(str);
            Rank = TransferRank(str);
        }

        //Translation of the first element of a string to int
        public int TransferFile(string str)
        {
            string symbols = "abcdefgh";
            int file = 0;
            for (int i = 0; i < symbols.Length; i++)
            {
                char symbol = symbols[i];
                if (str[0] == symbol)
                {
                    file = i + 1;
                }
            }
            return file;
        }

        //Translation of the second element of a string to int
        public int TransferRank(string str)
        {
            return str[1] - '0';
        }
        public override bool Equals(object obj)
        {
            return (File == (obj as Cell).File && Rank == (obj as Cell).Rank);
        }
    }
}
