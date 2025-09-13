using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndFunction
{
    internal class Program
    {
        //static method, static function
        public static void helloWorld()
        {
            System.Console.WriteLine("hello Csharp");
        }
        public static float adition (float a, float b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {   
            helloWorld();
            int a = 3, b = 4;
            Console.WriteLine("{0}", adition(a, b));
        }
    }
}
