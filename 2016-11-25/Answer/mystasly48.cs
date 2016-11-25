using System;
public class Hello {
  public static void Main() {
    var line1 = Console.ReadLine().Split(' ');
    var line2 = Console.ReadLine().Split(' ');
    Console.WriteLine("{0} {1}\n{2} {3}", line2[1], line2[0], line1[1], line1[0]);
  }
}
