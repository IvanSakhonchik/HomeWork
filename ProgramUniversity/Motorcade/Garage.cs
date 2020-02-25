using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class Garage
    {
        int square;
        Adress adress;

        public Garage(int square, Adress adress)
        {
            this.square = square;
            this.adress = adress;
        }

        public override bool Equals(object obj)
        {
            return (square == (obj as Garage).square) && adress.Equals((obj as Garage).adress);
        }

        public override string ToString()
        {
            return ($"Square: {square}, {adress} ");
        }
    }
}
