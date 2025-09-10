using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int damage;
            double price;
            VuKhi vuKhi;
            Console.WriteLine("please enter name of weapon: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter damage: ");
            damage = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the price of weapon: ");
            price = double.Parse(Console.ReadLine());
            vuKhi = new VuKhi(name, damage, price);
            Console.WriteLine("This is your weapon: {0}, {1}, {2}", vuKhi.getName(), vuKhi.getDamage(), vuKhi.getPrice());
        }
    }
}
