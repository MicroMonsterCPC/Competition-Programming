using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('_');
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0) continue;
                input[i] = input[i][0].ToString().ToUpper() + input[i].Substring(1);
            }
            Console.WriteLine(string.Join("", input));
        }
    }
}
