using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

        for (int i=1; i <= 100; i++)
           {
                int nullCheck = 0;             
                if (i % 3 == 0)
                {
                    Console.Write("FIZZ");
                    nullCheck++;
                }
                if (i % 5 == 0)
                {
                    Console.Write("BUZZ");
                    nullCheck++;
                }
                if (nullCheck == 0)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            }
        }
    }
}
