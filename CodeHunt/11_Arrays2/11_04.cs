using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int[] list, int modBy)
    {
        return list.Select(x => x % modBy).ToArray();
    }
}