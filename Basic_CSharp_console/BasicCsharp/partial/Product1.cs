using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    internal partial class Product1
    {
        //Lớp trong lớp
        public class Manufactory
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }
        public Manufactory manufactory { get; set; }
        public double Price { set; get; }
        public string Name { set; get; }
        public string GetInfo()
        {
            return $"{Name} / {Price}: {description}, {manufactory.Name} va {manufactory.Description}";
        }
    }
}
