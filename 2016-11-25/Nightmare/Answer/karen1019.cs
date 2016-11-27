using System;
using System.Linq;
namespace gin_irekae {
  class Program {
    static void Main(string[] args) {
      string str_input = Console.ReadLine() + " " + Console.ReadLine() + " " + Console.ReadLine();
        int[] int_input = str_input.Split(' ').Select(x => int.Parse(x)).ToArray();
          int input_loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < input_loop; i++) {
              string input_move = Console.ReadLine();
              string[] str_move = input_move.Split(' ');
              str_move[1] = str_move[1] == "1A" ? "0" : str_move[1] == "1B" ? "1" : str_move[1] == "1C" ? "2" : str_move[1] == "1D" ? "3" : str_move[1] == "2A" ? "4" : str_move[1] == "2B" ? "5" : str_move[1] == "2C" ? "6" : str_move[1] == "2D" ? "7" : str_move[1] == "3A" ? "8" : str_move[1] == "3B" ? "9" : str_move[1] == "3C" ? "10" : "11";
              int int_move = int.Parse(str_move[1]);
              string str_plus = str_move[0] == "right" ? "1" : str_move[0] == "left" ? "-1" : str_move[0] == "top" ? "-4" : "4";
              int int_plus = int.Parse(str_plus);
              if ((str_move[0] == "right" && str_move[1] == "3") || (str_move[0] == "right" && str_move[1] == "7") || (str_move[0] == "right" && str_move[1] == "11") || (str_move[0] == "left" && str_move[1] == "0") || (str_move[0] == "left" && str_move[1] == "4") || (str_move[0] == "left" && str_move[1] == "8")) {
                int_plus = int_plus * - 3;
              } else if ((str_move[0] == "top" && str_move[1] == "0") || (str_move[0] == "top" && str_move[1] == "1") || (str_move[0] == "top" && str_move[1] == "2") || (str_move[0] == "top" && str_move[1] == "3") || (str_move[0] == "bottom" && str_move[1] == "8") || (str_move[0] == "bottom" && str_move[1] == "9") || (str_move[0] == "bottom" && str_move[1] == "10") || (str_move[0] == "bottom" && str_move[1] == "11")) {
                int_plus = int_plus * - 2;
              }
              int_input[int_move] = int_input[int_move + int_plus] ^ (int_input[int_move] ^= int_input[int_move + int_plus] ^= int_input[int_move] ^= int_input[int_move + int_plus]);
          }
          Console.WriteLine("{0} {1} {2} {3}\n{4} {5} {6} {7}\n{8} {9} {10} {11}", int_input[0], int_input[1], int_input[2], int_input[3], int_input[4], int_input[5], int_input[6], int_input[7], int_input[8], int_input[9], int_input[10], int_input[11]);
        }
    }
}
