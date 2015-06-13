using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int[] numbers, int amount)
    {
        return numbers.Select((c, i) => numbers[(i + numbers.Length - amount) % numbers.Length]).ToArray();
    }
}