using BenchmarkDotNet.Attributes;
using Test.BenchmarkTests.Models;

namespace Test.BenchmarkTests.Tests
{
  public class MathFunctionsTests
  {
    private MathFunctions _mathFunctions;

    [Params(1, 2)]
    public int Number { get; set; }

    [GlobalSetup]
    public void GlobalSetup()
    {
      _mathFunctions = new MathFunctions { Number = 5 };
    }

    [Benchmark]
    public long MeasureSquare()
    {
      _mathFunctions.Number = Number;
      return _mathFunctions.Square();
    }
  }
}
