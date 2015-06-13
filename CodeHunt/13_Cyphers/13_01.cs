using System;
using System.Linq;
public class Program
{
    public static string Puzzle(string s)
    {
        return new string(s.Select(x => (char)(x + 7 > 'z' ? x - 19 : x + 7)).ToArray());
    }
}