using System;

namespace FizzBuzzer.Lib
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            var output = string.Empty;
            
            if (input % 3 == 0)
            {
                output += "Fizz";
            }
            if (input % 5 == 0)
            {
                output += "Buzz";
            }
            if (string.IsNullOrWhiteSpace(output))
            {
                output = input.ToString();
            }
            
            return output;
        }
    }
}