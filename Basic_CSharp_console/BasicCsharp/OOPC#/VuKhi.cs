using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace OOPC_
{
    public class weapon
    {
        public string name;
        public int quantity;
        public int damage;
        public double price;
        public weapon() { }
        public weapon(string name, int quantity, int damage, double price)
        {
            this.name = name;
            this.quantity = quantity;
            this.damage = damage;
            this.price = price;
        }
        public void dealDamage (int damage)
        {
            this.damage = damage;
        }
        public void changePrice (double price)
            { this.price = price; }
        public int getDamage() { return this.damage; }
        public double getPrice() { return this.price; }
    }
}
