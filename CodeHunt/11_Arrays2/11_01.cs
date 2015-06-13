using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int[] a, int[] b)
    {
        return Enumerable.Range(0, Math.Max(a.Length, b.Length)).Select(i => i >= b.Length ? a[i] : Math.Abs((i >= a.Length ? 0 : a[i]) - b[i])).ToArray();
    }
}