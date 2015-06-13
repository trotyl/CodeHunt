using System;
using System.Linq;
public class Program
{
    public static int Puzzle(int[][] input)
    {
        return input.SelectMany(x => x).Max();
    }
}