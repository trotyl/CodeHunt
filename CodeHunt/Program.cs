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
            var n = 1;
            var res = string.Join("", Enumerable.Range(0, n + 1).Select(x => string.Join("", Enumerable.Range(0, x)) + new string('_', n - x)));

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
