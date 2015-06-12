using System;
using System.Text;
public class Program
{
    public static string Puzzle(string s)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            sb.Append(i == s.Length - 1 || s[i + 1] == ' ' ? char.ToUpper(s[i]) : s[i]);
        }
        return sb.ToString();
    }
}