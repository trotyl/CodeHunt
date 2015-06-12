using System;
using System.Linq;
public class Program
{
    public static string Puzzle(string word)
    {
        return String.Join(" ", new String('_', word.Length).ToArray());
    }
}