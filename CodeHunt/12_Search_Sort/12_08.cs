using System;
using System.Linq;
public class Program
{
    public static int Puzzle(int[] numbers)
    {
        long left = numbers[0];
        long right = numbers.Skip(1).Select(x => (long)x).Sum();
        for (int i = 1; i < numbers.Length; i++)
        {
            if (left == right || Math.Abs(left - right) % 4294967296 == 0)
            {
                return i - 1;
            }
            left += numbers[i];
            right -= numbers[i];
        }
        if (numbers.Select(x => (long)x).Sum() == 0)
        {
            return numbers.Length - 1;
        }
        return -1;
    }
}