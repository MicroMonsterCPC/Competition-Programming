using System;

public class Program {

  public static void Main() {

    var input = Console.ReadLine().Split('_');

    var result = new string[input.Length];

    for (int i = 0; i < input.Length; i++) {

      if (i == 0) {

        result[i] = input[i];

      } else {

        result[i] = input[i].Substring(0, 1).ToUpper() + input[i].Substring(1, input[i].Length-1);

      }
    
    }
    
Console.WriteLine(string.Join("", result));

  }

}