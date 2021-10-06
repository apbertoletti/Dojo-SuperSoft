using System;

namespace Entity
{
    public static class FizzBuzz
    {
        public const string Fizz = "Fizz";
        public const string Buzz = "Buzz";
        public const string FizzBuzz = "FizzBuzz";

        public string Resolver(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
                return FizzBuzz;

            if (num % 5 == 0)
                return Buzz;

            if (num % 3 == 0)
                return Fizz;

            return num.ToString();
        }

    }
}