using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            "123".All(x => x != null);
            var res = Puzzle("pa", "pr");
            Console.WriteLine("{0} {1} {2}", (int)('|'), (int)('}'), (int)('~'));
            Console.WriteLine(res);
            Console.ReadKey();
        }

        public static bool Puzzle(string a, string b)
        {
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (dic.ContainsKey(a[i]))
                {
                    dic[a[i]]++;
                }
                else
                {
                    dic[a[i]] = 1;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (dic.ContainsKey(a[i]))
                {
                    dic[a[i]]--;
                }
                else
                {
                    return false;
                }
            }
            return dic.All(x => x.Value == 0);
        }
    }
}
