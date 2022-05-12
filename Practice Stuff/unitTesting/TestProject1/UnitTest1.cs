using unitTesting;
using Xunit;


namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddTwoNumbers()
        {
            //Arrange - sets up test
            Calculator calc = new Calculator();

            //Act - runs test
            int result = calc.AddTwoNumbers(2, 3);

            //Assert - defines expected result

            Assert.Equal(5, result);

        }
    }
}