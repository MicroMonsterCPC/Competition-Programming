using System;
using System.Linq;
using System.Collections.Generic;

public class Test
{
    public static void Main()
    {
        var a = Console.ReadLine().Split(' ');
        var b = Console.ReadLine().Split(' ');
        Console.WriteLine("{0} {1}\n{2} {3}", b[1], b[0], a[1], a[0]);
    }
}