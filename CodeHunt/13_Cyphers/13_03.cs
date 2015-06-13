using System;
using System.Linq;
public class Program
{
    public static string Puzzle(string s)
    {
        return new string(s.Select((x, i) => {
            var tmp = x + 4 * i + 1;
            return (char)(tmp > 'z' ? (tmp - 'a') % 26 + 'a' : tmp);
        }).ToArray());
    }
}