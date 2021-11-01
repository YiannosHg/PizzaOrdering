using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrdering
{
    public partial class SettingsForm : Form
    {
        public List<PizzaSize> pizzaSizes = new List<PizzaSize>();

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

            pizzaSizes.Add(new PizzaSize("Small", 5.5, 2));
            pizzaSizes.Add(new PizzaSize("Medium", 11.75, 3));
            pizzaSizes.Add(new PizzaSize("Large", 15, 4));
        }
    }
}
