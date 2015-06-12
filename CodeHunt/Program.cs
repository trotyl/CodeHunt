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
            var b = "#";
            var n = 3;
            var res = string.Join(" ", Enumerable.Repeat(new string(b[0], n), n).Select((x, i) => x.Substring(0, i) + b[0] + x.Substring(i + 1, x.Length - i - 1))); 
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
