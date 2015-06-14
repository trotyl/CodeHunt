using System;
using System.Text;
public class Program
{
    public static string Puzzle(string s)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i += 2)
        {
            if (i != s.Length - 1)
            {
                sb.Append((char)((s[i] + s[i + 1]) / 2));
            }
            else
            {
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }
}