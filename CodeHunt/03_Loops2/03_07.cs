using System;
using System.Linq;
public class Program
{
    public static string Puzzle(string s)
    {
        return String.Join("", s.Select(x => (char)(117 < x ? x - 21 : x + 5)));
    }
}