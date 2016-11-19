using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer: ");
            string inputNumber = Console.ReadLine();

            // assume user enters valid input 
            ulong fibbedNumber = Fib(Convert.ToUInt32(inputNumber));
            Console.WriteLine("Result is: {0}", fibbedNumber);
        }

        // C# does not support tail call optimization.
        // http://rosettacode.org/wiki/Fibonacci_sequence#C.23
        public static ulong Fib(uint n)
        {
            return Fib(0, 1, n);
        }
        private static ulong Fib(ulong a, ulong b, uint n)
        {
            return (n < 1) ? a : (n == 1) ? b : Fib(b, a + b, n - 1);
        }
    }
}
