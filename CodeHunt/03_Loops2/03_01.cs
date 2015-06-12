using System;
public class Program
{
    public static int Puzzle(int number, int power)
    {
        return power == 0 ? 1 : number * Puzzle(number, power - 1);
    }
}