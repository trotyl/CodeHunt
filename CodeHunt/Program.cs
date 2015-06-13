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
            var input = Enumerable.Repeat(Enumerable.Range(0, 10).ToArray(), 10).ToArray();
            var sums = new int[input.Length];
            var res = input.Select(x => 
                x.Select((y, j) => {
                    sums[j] += y;
                    return y;
                }));
            Console.WriteLine(res.ToArray());

            Console.ReadKey();
        }
    }
}
