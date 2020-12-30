using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BenchmarkTests.Models
{
  public class MathFunctions
  {
    public int Number { get; set; }

    public long Square()
    {
      return this.Number * this.Number;
    }
  }
}
