using System;
public class Program
{
    public static bool Puzzle(string[] words)
    {
        for (int i = 0; i < words.Length - 1; i++)
        {
            if (string.Compare(words[i], words[i + 1]) > 0)
            {
                return false;
            }
        }
        return true;
    }
}