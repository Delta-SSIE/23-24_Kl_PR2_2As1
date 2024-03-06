using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_UnitTesting_01_Minimum
{
    public class EmptyInputException : Exception
    {
        public EmptyInputException(string? message) : base(message)
        {
        }
    }
}
