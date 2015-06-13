using System;
using System.Linq;
public class Program
{
    public static int Puzzle(string[] words, string s)
    {
        return words.Count(x => x == s);
    }
}