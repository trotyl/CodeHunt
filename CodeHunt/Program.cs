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
            var input = "a";
            var res = Puzzle(input);
            Console.WriteLine("{0} {1} {2}",(int)('|'),(int)('}'),(int)('~'));
            Console.WriteLine(res);
            Console.ReadKey();
        }

        public static string Puzzle(string s)
        {
            return new string(s.Select(x => (char)(x + 7 > 'z' ? x + 7 : x - 19)).ToArray());
        }
    }
}
