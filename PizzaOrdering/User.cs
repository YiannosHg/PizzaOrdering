using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdering
{
    class User
    {
        public User() { }

        public User(string name, string password, bool canEditSizes, bool canEditToppings, bool canEditUsers) 
        {
            Name = name;
            Password = password;
            CanEditSizes = canEditSizes;
            CanEditToppings = canEditToppings;
            CanEditUsers = canEditUsers;
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public bool CanEditSizes { get; set; }
        public bool CanEditToppings { get; set; }
        public bool CanEditUsers { get; set; }
    }
}
