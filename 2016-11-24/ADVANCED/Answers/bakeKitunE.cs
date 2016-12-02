using System;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        Console.WriteLine(new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" }[int.Parse(input[0]) - 1] == input[1] ? "OK" : "NG");
    }
}
