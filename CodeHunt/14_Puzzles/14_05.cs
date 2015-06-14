using System;
using System.Linq;
public class Program
{
    public static int Puzzle(int[] list)
    {
        return list.Distinct().Count();
    }
}