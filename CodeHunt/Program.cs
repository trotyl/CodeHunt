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

            var res = Enumerable.Range(0, 10).Select((x, i) => new { Index = i, Value = x }).GroupBy(x => x.Index / 2).Select(x => (int)(x.ToArray().Average(t => t.Value))).ToArray();
            Console.WriteLine("{0} {1} {2}", (int)('|'), (int)('}'), (int)('~'));
            Console.WriteLine(res);
            Console.ReadKey();
        }


    }
}
