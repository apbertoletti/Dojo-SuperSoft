using System;

namespace FizzBuzz.Lib
{
    public static class FizzBuzz
    {
        public static readonly string Fizz = "Fizz";
        public static readonly string Buzz = "Buzz";
        public static readonly string FB = "FizzBuzz";

        public static string Resolver(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
                return FB;

            if (num % 5 == 0)
                return Buzz;

            if (num % 3 == 0)
                return Fizz;

            return num.ToString();
        }

    }
}