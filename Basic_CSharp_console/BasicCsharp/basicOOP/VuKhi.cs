using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicOOP
{
    internal class VuKhi
    {
        string name;
        int damage;
        double price;
        public VuKhi(string name, int damage, double price)
        {
            this.name = name;
            this.damage = damage;
            this.price = price;
        }
        public VuKhi() { }
        public int damageTaken (int damage)
        {
            return damage;   
        }
        public void priceTaken(double price)
        {
            this.price = price;
        }
        public int getDamage()
        {
            return damage;
        }
        public double getPrice()
        {
            return price;
        }
        public string getName()
        {
            return name;
        }

    }
}
