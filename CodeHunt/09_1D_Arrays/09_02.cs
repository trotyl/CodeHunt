using System;
public class Program
{
    public static string Puzzle(string[] list)
    {
        return list[0] + list[list.Length - 1];
    }
}