using System;
public class Program
{
    public static string[][] Puzzle(string[][] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                var t = input[i][j];
                input[i][j] = input[j][i];
                input[j][i] = t;
            }
        }
        return input;
    }
}