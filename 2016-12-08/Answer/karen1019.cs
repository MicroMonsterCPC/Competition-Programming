using System;
using System.Globalization;

namespace bukatu {
  class Program {
    static void Main(string[] args) {
      TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
      string[] input = Console.ReadLine().Split('_');
      Console.Write(input[0]);
      for (int i = 1, n = 1; i < input.Length; i++, n++) {
        Console.Write(ti.ToTitleCase(input[n]));
      }
    }
  }
}
