using System;
public class Program
{
    public static int Puzzle(int i)
    {
        return i < 8 ? 0 : (i < 15 ? 7 : 21);
    }
}