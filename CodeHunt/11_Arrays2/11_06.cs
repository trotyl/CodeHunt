using System;
using System.Linq;
public class Program
{
    public static string[] Puzzle(int[] grades, int A, int B, int C, int D)
    {
        return grades.Select(x => x >= A ? "A" : x >= B ? "B" : x >= C ? "C" : x >= D ? "D" : "E").ToArray();
    }
}