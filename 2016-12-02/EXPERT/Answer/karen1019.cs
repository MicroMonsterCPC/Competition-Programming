using System;

namespace memo {
  class Program {
    static void Main(string[] args) {
      string input = Console.ReadLine();
      int len = input.Length;
      input = (len % 2 == 1) ? input + "0" : input;
      len = input.Length;
      int num1 = 0;
      string[] AtoZ = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
      for (int i = 0; i < len / 2 ; i++) {
        int answer = 0;
        string str_answer = "";
        for (int k = 0; k < 2; k++) {
          int num2 = 0;
          int int_word = 0;
          string str_word = input.Substring(num1, 1);
          if (char.IsNumber(str_word, 0)) {
            int_word = int.Parse(str_word);
            answer += int_word;
            str_answer = answer.ToString();
          } else {
            for (;;) {
              if (int_word != 0) {
                break;
              }
              int_word = (str_word == AtoZ[num2]) ? num2 + 1 : 0;
              num2++;
            }
            answer += int_word;
            str_answer = AtoZ[answer - 1];
          }
          num1++;
        }
        Console.Write(str_answer);
      }
    }
  }
}
