using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int quantity, damage;
            double price;
            Console.WriteLine("please enter the real name of shotgun: ");
            name = Console.ReadLine();
            Console.WriteLine("how many: ");
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("how much: ");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("damage in game: ");
            damage = int.Parse(Console.ReadLine());
            weapon shotGun = new weapon(name, quantity, damage, price);
            Console.WriteLine("success !");
            Console.WriteLine("Data: {0}, {1}, {2}, {3}", shotGun.name, shotGun.quantity, shotGun.damage, shotGun.price);

        }
    }
}
