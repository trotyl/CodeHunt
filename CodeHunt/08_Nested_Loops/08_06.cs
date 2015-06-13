using System;
using System.Linq;
public class Program
{
    public static string Puzzle(int size)
    {
        return string.Format("{0} {1}{0}", new string('$', size), string.Join("", Enumerable.Repeat("$" + new string('_', size - 2) + "$ ", size - 2)));
    }
}