using System;
using System.Linq;
public class Program
{
    public static string Puzzle(int t)
    {
        var raw = string.Join(" ", Enumerable.Repeat("a b c d e f g h i j k l m n o p q r s t u v w x y z", t));
        return raw.Substring(0, raw.Length - t * 2 + 1) + "z";
    }
}