using System;
using System.Threading;

namespace memotou {
  public class Program {
    static void Main() {
      string[] input = Console.ReadLine().Split(' ');
      int int_t = int.Parse(input[0]);
      int int_y = int.Parse(input[1]);
      string ONEline = ",";
      string answer = "";
      for (int i = 1; i < int_y + 1; i++) {
        answer += i + ",";
        for (int j = 1; j < int_t + 1; j++) {
          answer += (i * j).ToString() + ",";
        }
        answer = answer.Trim(',');
        answer += "\n";
      }
      for (int k = 1; k < int_t + 1; k++) {
        ONEline += k + ",";
      }
      ONEline = ONEline.Trim(',');
      Console.WriteLine(",{0}\n{1}", ONEline, answer);
    }
  }
}
