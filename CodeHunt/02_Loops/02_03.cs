using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int n)
    {
        return Enumerable.Range(0, n).Select(x => x * x).ToArray();
    }
}