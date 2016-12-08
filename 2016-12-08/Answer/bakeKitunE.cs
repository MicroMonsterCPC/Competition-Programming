using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('_');
            for (int i = 1; i < input.Length; i++)
            {
                input[i] = input[i][0].ToString().ToUpper() + input[i].Substring(1);
            }
            Console.WriteLine(string.Join("", input));
        }
    }
}
