using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CrossCutting.Exceptions
{
    public class IsNotPlayerException : Exception
    {
        public IsNotPlayerException(string message, Exception ex) : base(message, ex)
        {
            throw new NotImplementedException();
        }
    }
   
}
