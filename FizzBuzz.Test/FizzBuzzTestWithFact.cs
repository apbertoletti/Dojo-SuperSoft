using System;
using Xunit;
//using FizzBuzz.Lib;

namespace DojoFizzBuzz.Test
{
    public class FizzBuzzTestWithFact
    {


        [Fact]
        public void Quando_Num_1_Retorna_1()
        {
            //Arrange
            var result = string.Empty;

            //Act
            result = FizzBuzz.Lib.FizzBuzz.Resolver(1);

            //Assert
            Assert.Equal("1", result);
        }

        [Fact]
        public void Quando_Num_2_Retorna_2()
        {
            // Arrange
            var result = string.Empty;

            // Act
            result = FizzBuzz.Lib.FizzBuzz.Resolver(2);

            // Assert
            Assert.Equal("2", result);
        }

        [Fact]
        public void Quando_Num_3_Retorna_Fizz()
        {
            // Arrange
            var result = string.Empty;

            // Act
            result = FizzBuzz.Lib.FizzBuzz.Resolver(3);

            // Assert
            Assert.Equal(FizzBuzz.Lib.FizzBuzz.Fizz, result);
        }

        [Fact]
        public void Quando_Num_5_Retorna_Buzz()
        {
            // Arrange
            var result = string.Empty;

            // Act
            result = FizzBuzz.Lib.FizzBuzz.Resolver(5);

            // Assert 
            Assert.Equal(FizzBuzz.Lib.FizzBuzz.Buzz, result);
        }

        [Fact]
        public void Quando_Num_15_Retorna_FizzBuzz()
        {
            // Arrange
            var result = string.Empty;

            // Act
            result = FizzBuzz.Lib.FizzBuzz.Resolver(15);

            //Assert
            Assert.Equal(FizzBuzz.Lib.FizzBuzz.FB, result);
        }

        [Fact]
        public void Quando_Num_30_Retorna_FizzBuzz()
        {
            // Arrange
            var result = string.Empty;

            // Act
            result = FizzBuzz.Lib.FizzBuzz.Resolver(30);

            // Assert
            Assert.Equal(FizzBuzz.Lib.FizzBuzz.FB, result);

        }

        [Fact]
        public void Quando_Num_45_Retorna_FizzBuzz()
        {
            // Arrange
            var result = string.Empty;

            // Act
            result = FizzBuzz.Lib.FizzBuzz.Resolver(45);

            // Assert
            Assert.Equal(FizzBuzz.Lib.FizzBuzz.FB, result);

        }



    }
}
