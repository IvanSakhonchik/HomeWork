using System;
namespace Translation
{
    public class StringException:Exception
    {
        public StringException(string message) : base(message) { }
    }
}
