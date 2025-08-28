using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    internal class Program
    {
        struct threeValues
        {
            public int a, b, c;
            public threeValues (int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public int total(int a, int b, int c)
            {
                return (a + b + c);
            }
            
        }

        static void Main(string[] args)
        {
            
            int a, b, c;
            Console.WriteLine("enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter c: ");
            c = int.Parse(Console.ReadLine());
            threeValues firstStep = new threeValues (a, b, c);
            Console.WriteLine("perimeter values: {0}", firstStep.total(a, b, c));
        }
    }
}
