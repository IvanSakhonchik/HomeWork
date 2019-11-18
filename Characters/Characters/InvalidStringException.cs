using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersNS
{
    public class InvalidStringException : Exception
    {
        public InvalidStringException(string message) : base(message) { }

    }
}
