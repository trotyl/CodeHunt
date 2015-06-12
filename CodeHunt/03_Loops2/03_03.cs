using System;
using System.Linq;
public class Program
{
    public static int Puzzle(int lowerBound, int upperBound)
    {
        return Enumerable.Range(lowerBound, upperBound - lowerBound + 1).Aggregate(1, (sum, num) => sum * num);
    }
}