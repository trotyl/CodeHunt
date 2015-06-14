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
            
            var res = new Func<char,char>[] { x=>x };
            Console.WriteLine("{0} {1} {2}",(int)('|'),(int)('}'),(int)('~'));
            Console.WriteLine(res);
            Console.ReadKey();
        }

        public static string Puzzle(string s)
        {
            return new string(s.Select((x, i) => {
                var map = new[] { 2, 3, 19, 19 };
                return (char)((x + map[i % 4]) % 26 + 'a');
            }).ToArray());
        }
    }
}
