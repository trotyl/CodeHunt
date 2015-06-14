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

            var res = IsPrime(3);
            Console.WriteLine("{0} {1} {2}",(int)('|'),(int)('}'),(int)('~'));
            Console.WriteLine(res);
            Console.ReadKey();
        }

        private static bool IsPrime(int f)
        {
            if (f == 1)
            {
                return false;
            }
            if (f == 2)
            {
                return true;
            }
            if (f % 2 == 0)
            {
                return false;
            }
            var bount = (int)Math.Sqrt(f);
            for (int i = 3; i <= f; i += 2)
            {
                if (f % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
