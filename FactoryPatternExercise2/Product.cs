using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class Product
    {
        public Product()
        {
            Name = "Subaru";
            Price = 50000;
        }
        public string Name { get; set; } = "foo";
        public double Price { get; set; } = 25000;
    }
}
