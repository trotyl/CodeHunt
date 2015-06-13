using System;
public class Program
{
    public static bool Puzzle(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}