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

        public PizzaSize(string name, double prise, int freeToppings)
        {
            Name = name;
            Prise = prise;
            FreeToppings = freeToppings;
        }

        public string Name { get; set; }
        public double Prise { get; set; }
        public int FreeToppings { get; set; }
    }
}
