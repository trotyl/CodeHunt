using System;
using System.Linq;
public class Program
{
    public static string Puzzle(int i)
    {
        return (i.ToString().Distinct().Count() == 1 ? "" : "not a ") + "fancy year";
    }
}