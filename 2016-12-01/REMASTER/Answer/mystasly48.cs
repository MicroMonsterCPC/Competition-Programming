using System;
using System.Linq;
public class Hello {
  const string BORDER = "|";
  
  public static void Main() {
    int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int height = line[0];
    int width = line[1];
    Console.WriteLine("{0} {0}{1}{0}", BORDER, string.Join("|", Enumerable.Range(1, width).ToArray()));
    Console.WriteLine(CreateRowBorder(width));
    for (int i = 1; i <= height; i++) {
      Console.WriteLine(CreateRow(i, width));
    }
  }

  public static string CreateRowBorder(int column) {
    string rowBorder = BORDER + "---";
    string result = "";    
    for (int i = 0; i <= column; i++) {
      result += rowBorder;
    }
    result += BORDER;
    return result;
  }
  
  public static string CreateRow(int currentRow, int maxColumn) {
    string result = BORDER + currentRow.ToString();
    for (int i = 1; i <= maxColumn; i++) {
      result += BORDER + (currentRow * i).ToString();
    }
    result += BORDER;
    return result;
  }
}
