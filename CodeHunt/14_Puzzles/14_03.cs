using System;
public class Program
{
    public static bool Puzzle(int x, int f)
    {
        return f != 1 && x % f == 0 && IsPrime(f);
    }

    private static bool IsPrime(int f)
    {
        for (int i = 2; i <= Math.Sqrt(f); i++)
        {
            if (f % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}