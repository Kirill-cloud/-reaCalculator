using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АreaCalculator
{
    public class NegativeValueException : Exception
    {
        override public string Message => "Value must be non-negative";
    }
}
