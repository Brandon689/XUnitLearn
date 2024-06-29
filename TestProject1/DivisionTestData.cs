using System.Collections;

namespace TestProject1;

public class DivisionTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 10, 2, 5 };
        yield return new object[] { 0, 5, 0 };
        yield return new object[] { 15, 3, 5 };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
