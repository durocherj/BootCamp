using System;
using Xunit;
using ConsoleApp1;

namespace Calculator_Test
{
    public class CalcTest
    {
        [Fact]
        public void TestSum()
        {
            var calc = new Calculator();

            var sum = calc.CalcSum(15, 20);

            Assert.Equal(35, sum);    
        }

        [Fact]
        public void TestMultiply()
        {
            var calc = new Calculator();
            var multiply = calc.Multiply(7,4);
            Assert.Equal(28, multiply);
        }
    }
}
