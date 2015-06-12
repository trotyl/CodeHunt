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
            var res = string.Join("", Enumerable.Repeat<char>('a', 5));
            
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
