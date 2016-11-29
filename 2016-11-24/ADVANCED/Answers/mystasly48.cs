using System;
using System.Collections.Generic;
public class Hello {
  public static void Main() {
    var dictionary = GetDictionary();
    var input = Console.ReadLine().Split(' ');
    var i = int.Parse(input[0]);
    var c = input[1][0];
    Console.WriteLine((dictionary[i] == c) ? "OK" : "NO");
  }

  public static Dictionary<int, char> GetDictionary() {
    var dictionary = new Dictionary<int, char>();
    for (var i = 0; i < 26; i++) {
      dictionary.Add(i + 1, (char)(i + 65));
    }
    return dictionary;
  }
}
