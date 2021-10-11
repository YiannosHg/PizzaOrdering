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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            int freeIngredients = getSize();
        }

        int getSize()
        {
            int numOfIngredients = 0;
            if (smallRadioButton.Checked)
                numOfIngredients = 2;
            
            else if (mediumRadioButton.Checked)
                numOfIngredients = 3;
            
            else if (largeRadioButton.Checked)
                numOfIngredients = 4;
            
            return numOfIngredients;
        }

        int getIngredients()
        {
            int amountOfIngredients = 0;

            if (peperoniCheckBox.Checked)
                amountOfIngredients += 1;

            if (onionCheckBox.Checked)
                amountOfIngredients += 1;

            if (mushroomCheckBox.Checked)

            return amountOfIngredients;
        }
    }
}
