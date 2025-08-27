using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String student1 = "Nguyen Van A";
            String student2 = "Nguyen Van B";
            String student3 = "Nguyen Van C";
            String[] list;
            list = new string[3] { student1, student2, student3 };
            Console.WriteLine(list[1]);
            int count = list.Length;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(list[i]);
            }
            foreach (var count2 in list)
                Console.WriteLine(count2);
            Console.WriteLine(list.Length);
            Console.WriteLine(list.Rank);
            Console.WriteLine(list.Max());
            double[,] number = new double[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //String[][] suparray;
            //suparray = new String[2][3] { { 1, 2, 3}, {4, 5, 6}};
            //Here is jagged array
        }
    }
}
