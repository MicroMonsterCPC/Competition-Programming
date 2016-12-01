using System;
using System.Linq;
public class Hello {
  public static void Main() {
    int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int height = line[0];
    int width = line[1];
    Console.WriteLine("," + string.Join(",", Enumerable.Range(1, width).ToArray()));
    for (int i = 1; i <= height; i++) {
      Console.WriteLine(CreateRow(i, width));
    }
  }
  
  public static string CreateRow(int currentRow, int maxColumn) {
    var result = currentRow.ToString();
    for (int i = 1; i <= maxColumn; i++) {
      result += "," + (currentRow * i).ToString();
    }
    return result;
  }
}
