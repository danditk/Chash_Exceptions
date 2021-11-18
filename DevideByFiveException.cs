using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chash_Exceptions
{
    class DevideByFiveException : Exception
    {
        public DevideByFiveException()
        {
            Console.WriteLine("Błąd");
        }

        public DevideByFiveException(string message) : base(message + "\n \n Dzielenia przez 5")
        {
        }

        public DevideByFiveException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
