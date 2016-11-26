using System;
using System.Linq;

namespace gin_irekae
{
    class Program {
        static void Main(string[] args) {
            string str_input = Console.ReadLine() + " " + Console.ReadLine();
            int[] int_input = str_input.Split(' ').Select(x => int.Parse(x)).ToArray();
            int input3 = int.Parse(Console.ReadLine());
            for (int i = 0; i < input3; i++) {
                string input4 = Console.ReadLine();
                if (input4 == "left 1" || input4 == "right 1") {
                    int_input[0] = int_input[1] ^ (int_input[0] ^= int_input[1] ^= int_input[0] ^= int_input[1]);
                } else if (input4 == "left 2" || input4 == "right 2") {
                    int_input[2] = int_input[3] ^ (int_input[2] ^= int_input[3] ^= int_input[2] ^= int_input[3]);
                } else if (input4 == "top 1" || input4 == "bottom 1") {
                    int_input[0] = int_input[2] ^ (int_input[0] ^= int_input[2] ^= int_input[0] ^= int_input[2]);
                } else {
                    int_input[1] = int_input[3] ^ (int_input[1] ^= int_input[3] ^= int_input[1] ^= int_input[3]);
                }
            }
            Console.WriteLine("{0} {1}\n{2} {3}", int_input[0], int_input[1], int_input[2], int_input[3]);
        }
    }
}
