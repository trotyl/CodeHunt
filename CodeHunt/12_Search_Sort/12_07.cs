using System;
using System.Collections.Generic;
public class Program
{
    public static int[][] Puzzle(int[] numbers, int x)
    {
        var res = new List<int[]>();
        var dic = new Dictionary<int, List<int>>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (dic.ContainsKey(numbers[i]))
            {
                foreach (var ii in dic[numbers[i]])
                {
                    res.Add(new int[2] { ii, i });
                }
            }
            if (dic.ContainsKey(x - numbers[i]))
            {
                dic[x - numbers[i]].Add(i);
            }
            else
            {
                dic[x - numbers[i]] = new List<int> { i };

            }
        }
        return res.ToArray();
    }
}