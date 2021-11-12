using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrdering
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Login form is loaded first
            Application.Run(new LoginForm());
            // Checks if a user is loggedin to run the form otherwise 
            // if login form is closed by pressing 'X' PizzaOrderingForm runs
            if (LoggedIn.isLoggedIn)
                Application.Run(new PizzaOrderingForm());
        }
    }
}
