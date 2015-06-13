using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int[] numbers)
    {
        return numbers.Reverse().ToArray();
    }
}