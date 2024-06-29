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
}
