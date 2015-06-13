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
            var res = t.Select(x=>x).Concat(k.Select(x=>x));
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
