//using FizzBuzz.Lib;
using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var retorno = FizzBuzz.Lib.FizzBuzz.Resolver(i);
                Console.Write(retorno + ", ");
            }
        }
    }
}
