using System;
using System.Linq;
using System.Text;

public class Program
{
    public static string Puzzle(string s)
    {
        return string.Join("", s.Select((c, i) => i % 2 == 0 ? char.ToUpper(c) : c));
    }
}