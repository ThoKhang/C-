using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //phép nối chuỗi
            Console.WriteLine("Please enter a greeting: ");
            string greetings = Console.ReadLine();
            Console.WriteLine("Please enter your full name: ");
            string fullName = Console.ReadLine();
            string newString = greetings + " " + fullName;
            Console.WriteLine(newString);  
        }
    }
}
