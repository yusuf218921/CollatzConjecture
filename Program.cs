using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CollatzConjecture(7896540123134578971));
        }
        public static int CollatzConjecture(decimal number)
        {
            var iter = 0;
            while(number != 1)
            {
                if(number % 2 == 0)
                {
                    number /= 2;
                    iter++;
                    Console.WriteLine(number);
                }
                else
                {
                    number = (3 * number) + 1;
                    iter++;
                    Console.WriteLine(number);
                }
            }
            return iter;
        }

    }
}
