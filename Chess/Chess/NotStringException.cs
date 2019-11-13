using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class NotStringException:Exception
    {
        public NotStringException(string message) : base(message) { }
    }
}
