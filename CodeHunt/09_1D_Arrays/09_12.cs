using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int[] numbers, int amount)
    {
        return numbers.Skip(numbers.Length - amount).Take(amount).Concat(numbers.Take(numbers.Length - amount)).ToArray();
    }
}