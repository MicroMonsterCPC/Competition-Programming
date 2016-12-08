using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Select(i => int.Parse(i.ToString())).ToArray();
        int count = input.Length / 2;
        int geri = 0;
        for (int i = 0; i < count; i++)
        {
            Console.Write(input[geri] + input[geri + 1]);
            geri += 2;
        }
        Console.WriteLine(input.Length % 2 == 1 ? input[input.Length - 1].ToString() : "");
    }
}
