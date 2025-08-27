using System;

namespace BasicCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter a: ");
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i <= a; i++) 
                Console.WriteLine("this is a text: {0}",a);
        }
    }
}
