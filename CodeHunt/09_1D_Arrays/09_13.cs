using System;
public class Program
{
    public static int[] Puzzle(int[] numbers, int i, int j)
    {
        var t = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = t;
        return numbers;
    }
}