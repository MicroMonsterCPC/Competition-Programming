using System;
using System.Threading;
using System.Threading.Tasks;

class Program {
  static void Main() {
    string AtoZ = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string[] ONEto26 = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26" };
    string key = Console.ReadLine();
    string[] arr = key.Split(' ');
    int result_AtoZ = (AtoZ.IndexOf(arr[1]));
    int result_ONEto26 = Array.IndexOf(ONEto26, (arr[0]));
    if (result_AtoZ == result_ONEto26 && !(result_AtoZ == -1 && result_ONEto26 == -1)) {
        Console.WriteLine("OK");
      } else {
        Console.WriteLine("NO");
      }
    }
  }
