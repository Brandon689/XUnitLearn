using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitLearn;

namespace TestProject1;
public class CalculatorFixture
{
    public Calculator Calculator { get; }

    public CalculatorFixture()
    {
        Calculator = new Calculator();
    }
}
