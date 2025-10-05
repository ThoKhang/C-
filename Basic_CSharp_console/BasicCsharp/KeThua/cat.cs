using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    internal class cat : animal
    {
        public string Food;
        public cat() 
        {
            this.Legs = 4;
            this.Food = "Mouse";
            this.ShowLeg();
        }
        public void Eat()
        {
            Console.WriteLine(Food);
        }
    }
}
