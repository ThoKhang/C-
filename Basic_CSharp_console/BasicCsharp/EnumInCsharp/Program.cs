using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace EnumInCsharp
{
    internal class Program
    {
        enum WeekDay
        {
            Monday,     // = 0
            Tuesday,    // = 1
            Wednesday,  // = 2
            Thursday,   // = 3
            Friday,     // = 4
            Saturday,   // = 5
            Sunday      // = 6
        }
        static void Main(string[] args)
        {
            WeekDay today = WeekDay.Monday;
            Console.WriteLine(today);
            Console.WriteLine((int)today);
            

        }
    }
}
