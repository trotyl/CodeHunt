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
            var t = "123";
            var k = "456";
            var res = Enumerable.Repeat(Enumerable.Repeat(10, 10), 10).OrderByDescending(x => x.Sum()).First().ToArray();

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
