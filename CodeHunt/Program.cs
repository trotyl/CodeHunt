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
            var res = t.Select(x => "123").SelectMany(x => x).Count(c => c == ' ');

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
