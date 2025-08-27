using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter a:");
            a = int.Parse(Console.ReadLine());
            while (a < 10)
            {
                Console.WriteLine("this is a text: {0}", a);
                a = a+ 1;

            }
        }
    }
}
