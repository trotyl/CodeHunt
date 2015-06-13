using System;
using System.Linq;
public class Program
{
    public static string Puzzle(string s)
    {
        return new string(s.Select(x => (char)(x + 3 > '~' ? x - 76 : x + 3)).ToArray());
    }
}