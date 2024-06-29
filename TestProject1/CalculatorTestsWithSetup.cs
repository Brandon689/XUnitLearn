using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitLearn;

namespace TestProject1;
public class CalculatorTestsWithSetup : IDisposable
{
    private readonly Calculator _calculator;

    public CalculatorTestsWithSetup()
    {
        _calculator = new Calculator();
        // Setup code here
    }

    public void Dispose()
    {
        // Teardown code here
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsCorrectDifference()
    {
        int result = _calculator.Subtract(5, 3);
        Assert.Equal(2, result);
    }
}

