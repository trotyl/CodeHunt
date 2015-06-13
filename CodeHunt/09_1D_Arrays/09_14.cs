using System;
using System.Linq;
public class Program
{
    public static int[] Puzzle(int[] a, int[] b)
    {
        return Enumerable.Range(0, Math.Max(a.Length, b.Length)).Select(i => (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0)).ToArray();
    }
}