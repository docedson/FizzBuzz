using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numbers = 1; numbers <= 100; numbers++)
            {
                //Starting with the most specialized case, and working down to most generic case
                if (numbers % 3 == 0 && numbers % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (numbers % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (numbers % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(numbers);
                }
            }
            Console.ReadKey();

        }
    }
}
