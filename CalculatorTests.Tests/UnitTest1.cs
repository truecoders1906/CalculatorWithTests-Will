using System;
using Xunit;
using System.Collections.Generic;
using CalculatorWithTests;

namespace CalculatorTests.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(7, 4, 11)]
        [InlineData(1, 2, 3)]
        [InlineData(100, 200, 300)]
        [InlineData(1000, 10000, 11000)]
        [InlineData(null, 0, null)]
        [InlineData(0, null, null)]
        [InlineData(null, null, null)]
        public void Add(int? value1, int? value2, int? expectedAnswer)
        {
            
            //Arrange
            Calculator calculate = new Calculator();

            //Act           
             int? answer = calculate.Add(value1, value2);  //<- this is what is giving me trouble
            //int? answer = (value1 + value2); //Need to make above line work, so far it's giving me trouble.

            //Assert
            Assert.Equal(expectedAnswer, answer);
            
        }

        [Theory]
        [InlineData(7, 4, 3)]
        [InlineData(1, 2, -1)]
        [InlineData(100, 200, -100)]
        [InlineData(1000, 10000, -9000)]
        [InlineData(null, 0, null)]
        [InlineData(0, null, null)]
        [InlineData(null, null, null)]
        public void Subtract(int? value1, int? value2, int? expectedAnswer)
        {

            //Arrange
            Calculator calculate = new Calculator();

            //Act           
            int? answer = calculate.Subtract(value1, value2);            

            //Assert
            Assert.Equal(expectedAnswer, answer);

        }

        [Theory]
        [InlineData(7, 4, 28)]
        [InlineData(1, 2, 2)]
        [InlineData(100, 200, 20000)]
        [InlineData(1000, 10000, 10000000)]
        [InlineData(null, 0, null)]
        [InlineData(0, null, null)]
        [InlineData(null, null, null)]
        public void Multiply(int? value1, int? value2, int? expectedAnswer)
        {

            //Arrange
            Calculator calculate = new Calculator();

            //Act           
            int? answer = calculate.Multiply(value1, value2);

            //Assert
            Assert.Equal(expectedAnswer, answer);

        }


        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(400, 200, 2)]
        [InlineData(100000, 10000, 10)]
        [InlineData(null, 0, null)]
        [InlineData(0, null, null)]
        [InlineData(null, null, null)]
        public void Divide(int? value1, int? value2, int? expectedAnswer)
        {

            //Arrange
            Calculator calculate = new Calculator();

            //Act           
            int? answer = calculate.Divide(value1, value2);

            //Assert
            Assert.Equal(expectedAnswer, answer);

        }

        [Theory]
        [InlineData(6, 720)]
        [InlineData(5 ,120)]
        [InlineData(4, 24)]
        [InlineData(3, 6)]
        [InlineData(2, 2)]
        [InlineData(1, 1)]
        
        public void Factorial(int value1, int expectedAnswer)
        {

            //Arrange
            Calculator calculate = new Calculator();

            //Act           
            int answer = calculate.Factorial(value1);

            //Assert
            Assert.Equal(expectedAnswer, answer);

        }
    }
}
