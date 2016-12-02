using System;
using System.Linq;
public class Program {
  public static void Main() {
    string x = Console.ReadLine();
    if (IsNumber(x)) {
      int[] array = x.ToArray().Select(c => int.Parse(c.ToString())).ToArray();
      ExecuteNumber(array);
    } else {
      char[] array = x.ToArray();
      ExecuteString(array);
    }
  }
  
  private static void ExecuteNumber(int[] x) {
    int count = x.Length/2;
    for (int i = 0; i < count; i++) {
      Console.Write(x[i + i] + x[i + i + 1]);
    }
    Console.WriteLine((x.Length % 2 == 1) ? x[x.Length-1].ToString() : "");
  }
  
  private static void ExecuteString(char[] x) {
    int count = x.Length/2;
    for (int i = 0; i < count; i++) {
      Console.Write(GetChar(GetInt(x[i + i]) + GetInt(x[i + i + 1])));
    }
    Console.WriteLine((x.Length % 2 == 1) ? x[x.Length - 1].ToString() : "");
  }
  
  private static int GetInt(char c) {
    return (int)(c - 96);
  }
  
  private static char GetChar(int i) {
    while (i > 26) {
		i -= 26;
	}
	return (char)(i + 96);
  }
  
  private static bool IsNumber(string str) {
    long l;
    return long.TryParse(str, out l);
  }
}
