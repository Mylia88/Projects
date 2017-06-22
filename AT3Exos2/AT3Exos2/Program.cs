using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT3Exos2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            a = 5;
            b = a;
            b = b+5;
            Console.WriteLine("a={0}, b={1}", a, b);

            int[] tabA, tabB;
            tabA = new int[3] { 2, 5, 4 };
            tabB = tabA;
            tabB[0] = 1;
            Console.WriteLine("tabA = {0}, tabB = {1}", tabA[0], tabB[0]);
        }
    }
}
