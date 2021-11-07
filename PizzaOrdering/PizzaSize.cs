using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdering
{
    class PizzaSize
    {
        public PizzaSize() { }

        public PizzaSize(string name, double price, int freeToppings)
        {
            Name = name;
            Price = price;
            FreeToppings = freeToppings;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int FreeToppings { get; set; }
    }
}
