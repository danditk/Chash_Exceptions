using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chash_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Wynik: " + Division(0));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Nie nie da się podzielić przez zero, a program widzi, że " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("YYY, coś poszło nie tak!" + e.Message);
            }
            finally
            {
                Console.WriteLine("Ja i tak posprzątam :)");
            }

            Console.ReadKey();

        }

        public static float Division(int a)
        {
            if (a == 5)
            {
                throw new Exception("Nigdy nie dziel przez 5!");
            }

            return 10 / a;
        }
    }
}
