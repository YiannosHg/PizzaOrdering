using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdering
{
    class PizzaTopping
    {
        PizzaTopping() { }

        public PizzaTopping(string name, double prise)
        {
            Name = name;
            Prise = prise;
        }

        public string Name { get; set; }
        public double Prise { get; set; }
    }
}
