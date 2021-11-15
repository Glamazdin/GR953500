using GR953500.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class DemoTests
    {
        [Fact]
        public void StackReturnsPusshedValue()
        {
            // Arrange
            var value = "test value";
            var stack = new Stack<string>();
            stack.Push(value);

            // Act
            string result = stack.Pop();

            // Assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void DiscountIsApplied()
        {
            //Arrange
            Product prod = new Product() { Price = 100 };

            //Act
            prod.ApplyDiscount(10);

            //Assert
            Assert.Equal<decimal>(90, prod.Price);
        }

        [Fact]
        public void ExceptionGenerated()
        {
            var prod = new Product() { Price = 10 };

            Assert.Throws<ArgumentOutOfRangeException>(
                             () => prod.ApplyDiscount(10));
        }

        [Theory]
        [InlineData(2, 4, .5)]
        [InlineData(2, 4, 1)]
        [InlineData(3, 4, (double)3 / 4)]
        public void CanDivide(int a, int b, double c)
        {
            //arrange
            var calc = new Calculator();

            //assert
            Assert.Equal(c, calc.Div(a, b));
        }



    }
}
