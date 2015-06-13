using System;
using System.Linq;
public class Program
{
    public static int Puzzle(int[][] input)
    {
        var sums = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input[i].Length; j++)
            {
                sums[j] += input[i][j];
            }
        }
        return sums.Max();
    }
}