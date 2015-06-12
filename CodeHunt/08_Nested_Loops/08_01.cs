using System;
public class Program
{
    public static int Puzzle(int i, int j)
    {
        var res = 0;
        for (int k = i; k <= j; k++) res += Factorial(k);
        return res;
    }

    private static int Factorial(int n)
    {
        return n == 1 ? 1 : n * Factorial(n - 1);
    }
}