using System;
public class Program
{
    public static bool Puzzle(int[][] input)
    {
        var left = 0;
        var right = 0;
        for (int i = 0; i < input.Length; i++)
        {
            left += input[i][i];
            right += input[i][input.Length - i - 1];
        }
        return left == right;
    }
}