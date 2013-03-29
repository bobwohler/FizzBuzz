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
            // For every number between 1 and 100 that is divisible by 3, write "Fizz"
            // For every number between 1 and 100 that is divisible by 5, write "Buzz"
            // For every number between 1 and 100 that is divisible by both, write "FizzBuzz"
            // For every other number between 1 and 100 write "FizzBuzzNone"
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i.ToString());
                if (i % 3 == 0 && i % 5 != 0) { Console.WriteLine("Fizz - divisible by 3: {0}", i); }
                else if (i % 5 == 0 && i % 3 != 0) { Console.WriteLine("Buzz - divisible by 5: {0}", i); }
                else if (i % 3 == 0 && i % 5 == 0) { Console.WriteLine("FizzBuzz - divisible by 3 and 5: {0}", i); }
                else { Console.WriteLine("FizzBuzzNone - divisible by neither 3 or 5: {0}", i); }
            }
            Console.ReadLine();
        }
    }
}
