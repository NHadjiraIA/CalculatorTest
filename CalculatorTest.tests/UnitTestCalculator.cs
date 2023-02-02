using Xunit;
using Calculator;
namespace CalculatorTest.tests;

public class UnitTestCalculator
{
    [Theory]
    [InlineData(4,3,7)]
    [InlineData(5,3,8)]
    public void operation_SimpleValueShouldCalculate(int a , int b, int expected)
    {
        // Arrange
        
        //Act
        int actual = Calculator.Operator.operation('+', a ,b);
        //Assert
        Assert.Equal(expected, actual);
    }
}
