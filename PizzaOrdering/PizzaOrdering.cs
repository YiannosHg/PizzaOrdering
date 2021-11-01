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
    public partial class PizzaOrdering : Form
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

        // Variables
        double pizzaSizeCost = 0;
        double totalCost = 0;
        int freeIngredients = 0;
        int numOfIngredients = 0;
        string deliveryTime = null;
        SettingsForm settings = new SettingsForm();

        public PizzaOrdering()
        {
            InitializeComponent();
        }

        // Declaring what happens when Order button is clicked
        private void orderButton_Click(object sender, EventArgs e)
        {
            int result = checkDeliveryTime();

            if (0 == result)
            {
                MessageBox.Show("Please enter a valid time", "Time not a valid ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (1 == result)
                MessageBox.Show("Provide delivery time on the future", "Time not a valid ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult dialogResult = MessageBox.Show($"The total for your pizza is € {totalCost} (to be delivered at {deliveryTime}), " +
                    $"are you sure you want to order ? ", "Order confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (dialogResult == DialogResult.Yes)
                    MessageBox.Show("Order successfully completed", "Order result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("The order was canceled", "Order result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        // Declaring what happens when each of the 3 radio buttons is pressed
        private void smallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setPizzaSize(smallSizeCost, smallFreeIngredients);
            setTotalCost();
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setPizzaSize(mediumSizeCost, mediumFreeIngredients);
            setTotalCost();
        }

        private void largeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setPizzaSize(largeSizeCost, largeFreeIngredients);
            setTotalCost();
        }

        // Declaring what happens when each of the 6 check boxes is pressed
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

        /**
        * Function <code>setPizzaSize</code> sets the pizza cost and its free ingredients
        * based on the pizza size. Shows a message of the number of free ingredients
        * and gives access to the ingredients, the time and the order button.
        * <BR>
        * @param cost The cost of the pizza based on its size.
        * @param ingredients The number of free ingredients based on the pizza size.
        */
        void setPizzaSize(double cost, int ingredients)
        {
            IngredientsGroupBox.Enabled = true;
            timeMaskedTextBox.Enabled = true;
            priceLabel.Enabled = true;
            orderButton.Visible = true;
            pizzaSizeCost = cost;
            freeIngredients = ingredients;
            ingredientsLabel.Text = "Ingredients: Free up to: " + freeIngredients + Environment.NewLine + "0.75 for each extra ingredient";
            priceLabel.Text = pizzaSizeCost.ToString();
        }

        /**
        * Function <code>setTotalCost</code> sets the pizza cost based on the number 
        * of selected ingredients.
        */
        void setTotalCost()
        {
            if (numOfIngredients > freeIngredients)
                totalCost = (numOfIngredients - freeIngredients) * extraIngredientCost + pizzaSizeCost;
            else
                totalCost = pizzaSizeCost;

            priceLabel.Text = totalCost.ToString();
        }

        /**
         * Function <code>checkDeliveryTime</code> checks if the imput time
         * is valid.
         * Returns:
         *  0: Not valid time
         *  1: Time in the past
         *  2: Time is valid
         */
        int checkDeliveryTime()
        {
            string currentTime = DateTime.Now.ToShortTimeString().Replace(":", "");
            int numCurrentTime = int.Parse(currentTime);
            int numDeliveryTime = int.Parse(timeMaskedTextBox.Text.Replace(":", ""));
            
            deliveryTime = timeMaskedTextBox.Text;

            if (numDeliveryTime < 0 || numDeliveryTime > 2359) // Check if is a valid number
                return 0;
            else if (int.Parse(deliveryTime[3].ToString()) > 5) // Check if is a valid number
                return 0;
            else if (numCurrentTime > numDeliveryTime) // Check if current time is greater than delivery time
                return 1;
            else
                return 2;
        }
    }
}
