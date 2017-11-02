using System;

namespace FizzBuzzer
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(Lib.FizzBuzzer.GetValue(i));
            }
            Console.ReadKey();
        }
    }
}