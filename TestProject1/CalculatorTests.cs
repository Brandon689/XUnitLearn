using XUnitLearn;

namespace TestProject1;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        var calculator = new Calculator();
        int result = calculator.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    public void Add_MultipleScenarios_ReturnsCorrectSum(int a, int b, int expected)
    {
        var calculator = new Calculator();
        int result = calculator.Add(a, b);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> MultiplicationData =>
    new List<object[]>
    {
        new object[] { 2, 3, 6 },
        new object[] { -2, 4, -8 },
        new object[] { 0, 5, 0 }
    };

    [Theory]
    [MemberData(nameof(MultiplicationData))]
    public void Multiply_MultipleScenarios_ReturnsCorrectProduct(int a, int b, int expected)
    {
        var calculator = new Calculator();
        int result = calculator.Multiply(a, b);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        var calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(1, 0));
    }

    [Theory]
    [ClassData(typeof(DivisionTestData))]
    public void Divide_MultipleScenarios_ReturnsCorrectQuotient(double a, double b, double expected)
    {
        var calculator = new Calculator();
        double result = calculator.Divide(a, b);
        Assert.Equal(expected, result, 3); // 3 decimal places precision
    }

}
