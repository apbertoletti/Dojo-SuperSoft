using System;
using Xunit;
//using FizzBuzz.Lib;

namespace DojoFizzBuzz.Test
{
    public class FizzBuzzTestWithTheory
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(45, "FizzBuzz")]
        public void Resolver_Test(int num, string esperado)
        {
            //Arrange
            var result = string.Empty;

            //Act
            result = FizzBuzz.Lib.FizzBuzz.Resolver(num);

            //Assert
            Assert.Equal(esperado, result);
        }
    }
}
