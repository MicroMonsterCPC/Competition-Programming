using System;
using System.Linq;
using System.Collections.Generic;
public class Hello {
  public static void Main() {
    List<string> line1 = Console.ReadLine().Split(' ').ToList();
    List<string> line2 = Console.ReadLine().Split(' ').ToList();
    int count = int.Parse(Console.ReadLine());
    for (int i = 0; i < count; i++) {
      string[] locate = Console.ReadLine().Split(' ');
      switch (locate[0]) {
        case "left":
          goto case "right";
        case "right":
          switch (int.Parse(locate[1])) {
            case 1: {
              string[] saved = line1.ToArray();
              line1[0] = saved[1];
              line1[1] = saved[0];
              break;
            }
            case 2: {
              string[] saved = line2.ToArray();
              line2[0] = saved[1];
              line2[1] = saved[0];
              break;
            }
          }
          break;

        case "top":
          goto case "bottom";
        case "bottom":
          switch (int.Parse(locate[1])) {
            case 1: {
              string[] saved = { line1[0], line2[0] };
              line1[0] = saved[1];
              line2[0] = saved[0];
              break;
            }
            case 2: {
              string[] saved = { line1[1], line2[1] };
              line1[1] = saved[1];
              line2[1] = saved[0];
              break;
            }
          }
          break;
      }
    }
    Console.WriteLine("{0}\n{1}", string.Join(" ", line1), string.Join(" ", line2));
  }
}
