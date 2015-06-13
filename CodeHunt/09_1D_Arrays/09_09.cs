using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int[] numbers)
    {
        return numbers.Select(x => -x).ToArray();
    }
}