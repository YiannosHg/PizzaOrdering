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
        // Price of pizza based on its size
        private const double smallSizeCost = 5.50;
        private const double mediumSizeCost = 11.75;
        private const double largeSizeCost = 15.00;

        // Free ingredients based on pizza size
        private const int smallFreeIngredients = 2;
        private const int mediumFreeIngredients = 3;
        private const int largeFreeIngredients = 4;

        // Extra ingredient cost
        private const double extraIngredientCost = 0.75;

        double pizzaSizeCost = 0;
        double totalCost = 0;
        int freeIngredients = 0;
        int numOfIngredients = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            
        }

        private void smallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsGroupBox.Enabled = true;
            pizzaSizeCost = smallSizeCost;
            freeIngredients = smallFreeIngredients;
            ingredientsLabel.Text = "Ingredients: Free up to: " + freeIngredients + Environment.NewLine +"0.75 for each extra ingredient";
            priceLabel.Text = pizzaSizeCost.ToString();
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsGroupBox.Enabled = true;
            pizzaSizeCost = mediumSizeCost;
            freeIngredients = mediumFreeIngredients;
            ingredientsLabel.Text = "Ingredients: Free up to: " + freeIngredients + Environment.NewLine + "0.75 for each extra ingredient";
            priceLabel.Text = pizzaSizeCost.ToString();
        }

        private void largeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsGroupBox.Enabled = true;
            pizzaSizeCost = largeSizeCost;
            freeIngredients = largeFreeIngredients;
            ingredientsLabel.Text = "Ingredients: Free up to: " + freeIngredients + Environment.NewLine + "0.75 for each extra ingredient";
            priceLabel.Text = pizzaSizeCost.ToString();
        }

        private void peperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (peperoniCheckBox.Checked == false)
                --numOfIngredients;
            else
                ++numOfIngredients;

            setTotalCost();
        }

        private void onionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onionCheckBox.Checked == false)
                --numOfIngredients;
            else
                ++numOfIngredients;

            setTotalCost();
        }

        private void mushroomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mushroomCheckBox.Checked == false)
                --numOfIngredients;
            else
                ++numOfIngredients;

            setTotalCost();
        }

        private void blackOlivesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (blackOlivesCheckBox.Checked == false)
                --numOfIngredients;
            else
                ++numOfIngredients;

            setTotalCost();
        }

        private void pineappleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pineappleCheckBox.Checked == false)
                --numOfIngredients;
            else
                ++numOfIngredients;

            setTotalCost();
        }

        private void extraCheeseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (extraCheeseCheckBox.Checked == false)
                --numOfIngredients;
            else
                ++numOfIngredients;

            setTotalCost();
        }

        void setTotalCost()
        {
            if (numOfIngredients > freeIngredients)
                totalCost = (numOfIngredients - freeIngredients) * extraIngredientCost + pizzaSizeCost;
            else
                totalCost = pizzaSizeCost;

            priceLabel.Text = totalCost.ToString();
        }
    }
}
