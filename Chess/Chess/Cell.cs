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
            File = str[0] + 1 - 'a';
            Rank = str[1] - '0';
        }
        public string CheckColour()
        {
            if ((File + Rank) % 2 == 0)
            {
                return "Black";
            }
            else return "White";
        }

        public override bool Equals(object obj)
        {
            return (File == (obj as Cell).File && Rank == (obj as Cell).Rank);
        }
    }
}
