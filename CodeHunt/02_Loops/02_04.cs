using System;
using System.Linq;
public class Program
{
    public static int Puzzle(int[] v)
    {
        return (int)v.Sum(x => (long)x);
    }
}