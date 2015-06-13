using System;
using System.Linq;
public class Program
{
    public static int Puzzle(int[] numbers, int x)
    {
        return numbers.Count(t => t == x);
    }
}