using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static List<List<string>> lines = new List<List<string>>();
    static Dictionary<string, int> location = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 }, { "D", 4 } };

    static void Main(string[] args)
    {
        List<string> line1 = Console.ReadLine().Split(' ').ToList();
        List<string> line2 = Console.ReadLine().Split(' ').ToList();
        List<string> line3 = Console.ReadLine().Split(' ').ToList();
        int count = int.Parse(Console.ReadLine());

        lines.Add(line1);
        lines.Add(line2);
        lines.Add(line3);

        for (int i = 0; i < count; i++)
        {
            var command = Console.ReadLine().Split(' ');

            Move(command);

        }

        foreach (var line in lines)
        {
            Console.WriteLine(string.Join(" ", line));
        }
    }

    static void Move(string[] command)
    {
        char[] xy = command[1].ToArray();       // 座標

        int fromY = int.Parse(xy[0].ToString()) - 1;
        int fromX = location[xy[1].ToString()] - 1;

        int toY = 0;
        int toX = 0;

        switch (command[0])
        {
            case "left":
                toY = fromY;
                toX = fromX == 0 ? fromX + 3 : fromX - 1;
                break;
            case "right":
                toY = fromY;
                toX = fromX == 3 ? fromX - 3 : fromX + 1;
                break;
            case "top":
                toY = fromY == 0 ? fromY + 2 : fromY - 1;
                toX = fromX;
                break;
            case "bottom":
                toY = fromY == 2 ? fromY - 2 : fromY + 1;
                toX = fromX;
                break;
            default:
                break;
        }

        string from = lines[fromY][fromX];
        string to = lines[toY][toX];

        lines[fromY][fromX] = to;
        lines[toY][toX] = from;
    }
}
