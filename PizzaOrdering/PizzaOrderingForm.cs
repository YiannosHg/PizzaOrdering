using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrdering
{
    public partial class PizzaOrderingForm : Form
    {
        // Extra ingredient cost
        private const double extraIngredientCost = 0.75;

        // Variables
        double pizzaSizeCost = 0;
        double totalCost = 0;
        int freeToppings = 0;
        int numOfToppings = 0;
        string deliveryTime = null;
        SettingsForm settingsForm = new SettingsForm();
        AboutForm aboutForm = new AboutForm();

        // RadioButtons variables
        private RadioButton[] sizesRadioButtons;
        List<PizzaSize> pizzaSizes = new List<PizzaSize>();
        
        // CheckBoxes variables
        private CheckBox[] toppingsCheckBoxes; // Declare array of toppings checkboxes
        List<PizzaTopping> pizzaToppings = new List<PizzaTopping>();

        public PizzaOrderingForm()
        {
            InitializeComponent();
        }

        // Declares what happens when PizzaOrderingForm is loaded
        private void PizzaOrderingForm_Load(object sender, EventArgs e)
        {
            // Sizes radio buttons
            getPizzaSizesFromFile();
            sizesRadioButtons = new RadioButton[pizzaSizes.Count]; // Create an array of sizes radiobuttons

            for (int i = 0; i < pizzaSizes.Count; ++i)
            {
                sizesRadioButtons[i] = new RadioButton(); // Add radiobutton in array

                // PROPERTIES
                sizesRadioButtons[i].Text = pizzaSizes[i].Name;
                sizesRadioButtons[i].Font = sizesGroupBox.Font;
                sizesRadioButtons[i].Tag = i; // The postition of the radiobutton inside the list. Used to get properties (fields) from pizzaSizes list
                sizesGroupBox.Controls.Add(sizesRadioButtons[i]);
                sizesRadioButtons[i].Location = new Point(sizesRadioButtons[i].Location.X + 10 /*+ (30*i)*/, sizesRadioButtons[i].Location.Y + 50 + (20 * i));

                // EVENT
                sizesRadioButtons[i].CheckedChanged += new System.EventHandler(sizesRadioButtons_CheckedChanged);
            }

            // Toppings checked boxes
            getToppingsFromFile();
            toppingsCheckBoxes = new CheckBox[pizzaToppings.Count]; // Create array of toppings checkboxes
            //peperoniCheckBox.CheckedChanged += new System.EventHandler(toppingsCheckBoxes_CheckedChanged);

            for (int i = 0; i < pizzaToppings.Count; ++i)
            {
                toppingsCheckBoxes[i] = new CheckBox(); // Add checkbox in array

                // PROPERTIES
                toppingsCheckBoxes[i].Text = pizzaToppings[i].Name;
                toppingsCheckBoxes[i].Font = toppingsGroupBox.Font;
                toppingsGroupBox.Controls.Add(toppingsCheckBoxes[i]);
                toppingsCheckBoxes[i].Location = new Point(toppingsCheckBoxes[i].Location.X + 10 /*+ (30*i)*/, toppingsCheckBoxes[i].Location.Y + 50 + (20 * i));

                // EVENT
                toppingsCheckBoxes[i].CheckedChanged += new System.EventHandler(toppingsCheckBoxes_CheckedChanged);
            }
            //this.Controls.AddRange(toppingsCheckBoxes); // Not needed because CheckBox is added at the GroupBox
        }

        // Declaring what happens when Order button is clicked
        private void orderButton_Click(object sender, EventArgs e)
        {
            int result = checkDeliveryTime();

            if (0 == result)           
                MessageBox.Show("Please enter a valid time", "Time not a valid ", MessageBoxButtons.OK, MessageBoxIcon.Error);           
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

        // Declaring what happens when each of the radio buttons is pressed
        private void sizesRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            int position = (int)((RadioButton)sender).Tag;
            setPizzaSize(pizzaSizes[position].Price, pizzaSizes[position].FreeToppings);
            setTotalCost();
        }

        // Declaring what happens when each of the check boxes is pressed
        private void toppingsCheckBoxes_CheckedChanged(object sender, System.EventArgs e)
        {
            if(((CheckBox)sender).Checked == false)
                --numOfToppings;
            else
                    ++numOfToppings;

            setTotalCost();
        }

        /**
        * Function <code>setPizzaSize</code> sets the pizza cost and its free Toppings
        * based on the pizza size. Shows a message of the number of free Toppings
        * and gives access to the Toppings, the time and the order button.
        * <BR>
        * @param cost The cost of the pizza based on its size.
        * @param Toppings The number of free Toppings based on the pizza size.
        */
        void setPizzaSize(double cost, int toppings)
        {
            toppingsGroupBox.Enabled = true;
            timeMaskedTextBox.Enabled = true;
            priceLabel.Enabled = true;
            orderButton.Visible = true;
            pizzaSizeCost = cost;
            freeToppings = toppings;
            toppingsLabel.Text = "Free toppings: " + freeToppings + "   |   € 0.75 for each extra ingredient";
            priceLabel.Text = pizzaSizeCost.ToString();
        }

        /**
        * Function <code>setTotalCost</code> sets the pizza cost based on the number 
        * of selected Toppings.
        */
        void setTotalCost()
        {
            if (numOfToppings > freeToppings)
                totalCost = (numOfToppings - freeToppings) * extraIngredientCost + pizzaSizeCost;
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
            try
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
            catch { return 0; };
        }

        // Function that gets the content of toppings file and stores it in the list
        void getPizzaSizesFromFile()
        {
            // Variable that holds the content from the json file that holds the pizza sizes
            var pizzaSizesInput = File.ReadAllText("pizzaSizesInputFile.json");

            // Gets the pizza sizes and stores them into a list of class objects
            pizzaSizes = JsonConvert.DeserializeObject<List<PizzaSize>>(pizzaSizesInput);
        }

        // Function that gets the content of toppings file and stores it in the list
        void getToppingsFromFile()
        {
            // Variable that holds the content from the json file that holds the pizza sizes
            var pizzaToppingsInput = File.ReadAllText("pizzaToppingsInputFile.json");

            // Gets the pizza sizes and stores them into a list of class objects
            pizzaToppings = JsonConvert.DeserializeObject<List<PizzaTopping>>(pizzaToppingsInput);
        }

        // Opens the Settings form
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }

        // Opens the About form
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm.ShowDialog();   
        }
    }
}
