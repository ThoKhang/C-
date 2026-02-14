using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    internal class animal
    {
        public int Legs { get; set; }
        public float Weight { get; set; }
        public void ShowLeg()
        {
            Console.WriteLine($"Legs: {Legs}");
        }
    }
}
