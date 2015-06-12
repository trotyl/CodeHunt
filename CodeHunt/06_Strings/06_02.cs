using System;
using System.Linq;
public class Program
{
    public static string Puzzle(string s)
    {
        return String.Join("", s.Select((c, i) => i % 2 == 0 ? Char.ToUpper(c) : c));
    }
}