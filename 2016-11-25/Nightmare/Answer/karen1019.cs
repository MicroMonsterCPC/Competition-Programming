using System;
using System.Linq;
namespace gin_irekae {
    class Program {
        static void Main(string[] args) {
        string str_input = Console.ReadLine() + " " + Console.ReadLine() + " " + Console.ReadLine();
            int[] int_input = str_input.Split(' ').Select(x => int.Parse(x)).ToArray();
            int input3 = int.Parse(Console.ReadLine());
            for (int i = 0; i < input3; i++) {
                string input4 = Console.ReadLine();
                string[] input4_ = input4.Split(' ');
                input4_[1] = input4_[1] == "1A" ? "0" : input4_[1] == "1B" ? "1" : input4_[1] == "1C" ? "2" : input4_[1] == "1D" ? "3" : input4_[1] == "2A" ? "4" : input4_[1] == "2B" ? "5" : input4_[1] == "2C" ? "6" : input4_[1] == "2D" ? "7" : input4_[1] == "3A" ? "8" : input4_[1] == "3B" ? "9" : input4_[1] == "3C" ? "10" : "11";
                int input4__ = int.Parse(input4_[1]);
                if (input4_[0] == "right") {
                    if (!(input4__ == 3 || input4__ == 7 || input4__ == 11)) {
                        int_input[input4__] = int_input[input4__ + 1] ^ (int_input[input4__] ^= int_input[input4__ + 1] ^= int_input[input4__] ^= int_input[input4__ + 1]);
                    } else {
                        int_input[input4__] = int_input[input4__ - 3] ^ (int_input[input4__] ^= int_input[input4__ - 3] ^= int_input[input4__] ^= int_input[input4__ - 3]);
                    }
                } else if (input4_[0] == "left") {
                    if (!(input4__ == 0 || input4__ == 4 || input4__ == 8)) {
                       int_input[input4__] = int_input[input4__ - 1] ^ (int_input[input4__] ^= int_input[input4__ - 1] ^= int_input[input4__] ^= int_input[input4__ - 1]);
                    } else {
                       int_input[input4__] = int_input[input4__ + 3] ^ (int_input[input4__] ^= int_input[input4__ + 3] ^= int_input[input4__] ^= int_input[input4__ + 3]);
                    }
                } else if (input4_[0] == "top") {
                    if (!(input4__ == 0 || input4__ == 1 || input4__ == 2 || input4__ == 3)) {
                       int_input[input4__] = int_input[input4__ - 4] ^ (int_input[input4__] ^= int_input[input4__ - 4] ^= int_input[input4__] ^= int_input[input4__ - 4]);
                    } else {
                       int_input[input4__] = int_input[input4__ + 8] ^ (int_input[input4__] ^= int_input[input4__ + 8] ^= int_input[input4__] ^= int_input[input4__ + 8]);
                    }
                } else { //bottom
                    if (!(input4__ == 8 || input4__ == 9 || input4__ == 10 || input4__ == 11)) {
                       int_input[input4__] = int_input[input4__ + 4] ^ (int_input[input4__] ^= int_input[input4__ + 4] ^= int_input[input4__] ^= int_input[input4__ + 4]);
                   } else {
                       int_input[input4__] = int_input[input4__ - 8] ^ (int_input[input4__] ^= int_input[input4__ - 8] ^= int_input[input4__] ^= int_input[input4__ - 8]);
                   }
               }
            }
            Console.WriteLine("{0} {1} {2} {3}\n{4} {5} {6} {7}\n{8} {9} {10} {11}", int_input[0], int_input[1], int_input[2], int_input[3], int_input[4], int_input[5], int_input[6], int_input[7], int_input[8], int_input[9], int_input[10], int_input[11]);
        }
    }
}
