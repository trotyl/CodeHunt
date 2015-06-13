using System;
using System.Linq;
public class Program
{
    public static string Puzzle(string s)
    {
        return new string(s.Select((x, i) => {
            var map = new[] { 2, 3, 19, 19 };
            var tmp = x + map[i % 4];
            return (char)(tmp > 'z' ? (x + map[i % 4] - 'a') % 26 + 'a' : tmp);
        }).ToArray());
    }
}