using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product1 loq = new Product1();
            loq.Name = "Lenovo LOQ";
            loq.Price = 2000;
            loq.description = "Sieu manh sieu ngau";
            loq.manufactory = new Product1.Manufactory();
            loq.manufactory.Name = "England";
            loq.manufactory.Description = " Quoc gia dep";
            Console.WriteLine(loq.GetInfo());
        }
    }
}
