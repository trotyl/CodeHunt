using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int[] numbers, int x)
    {
        return numbers.Select((t, i) => t == x ? i : -1).Where(t => t >= 0).ToArray();
    }
}