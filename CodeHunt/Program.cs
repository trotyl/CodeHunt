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
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            var t = 4394967296;
            var input = new int[] { 1536835584, 268500992, -236443443, -2104172274, 847444531, -1902636430, 369174912 };
            
            var res = Puzzle(input);
            Console.WriteLine(res);
            Array.Sort(input);
            Console.ReadKey();
        }

        public static bool Puzzle(int[] numbers)
        {
            return numbers.Select(x => (int?)x).Aggregate((int?)int.MinValue, (o, x) => x != null && x >= o ? x : null) != null;
        }
    }
}
