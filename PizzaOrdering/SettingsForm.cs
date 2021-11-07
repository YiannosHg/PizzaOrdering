using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace PizzaOrdering
{
    public partial class SettingsForm : Form
    {
        List<PizzaSize> pizzaSizes = new List<PizzaSize>();
        List<PizzaTopping> pizzaToppings = new List<PizzaTopping>();

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        { 
            getSizesFromFile();
            getToppingsFromFile();

            // Sets the source of data to be shown in DataGridView
            pizzaSizeDataGridView.DataSource = new BindingList<PizzaSize>(pizzaSizes);
            pizzaToppingsDataGridView.DataSource = new BindingList<PizzaTopping>(pizzaToppings);
        }

        // Declares what happens when saveSizesButton button is clicked
        private void saveSizesButton_Click(object sender, EventArgs e)
        {
            setSizesToFile();
            MessageBox.Show("Successfuly saved the size changes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Declares what happens when resetSizesButton button is clicked
        private void resetSizesButton_Click(object sender, EventArgs e)
        {
            getSizesFromFile();
            pizzaSizeDataGridView.DataSource = new BindingList<PizzaSize>(pizzaSizes);
        }

        // Declares what happens when saveToppingsButton is clicked
        private void saveToppingsButton_Click(object sender, EventArgs e)
        {
            setToppingsToFile();
            MessageBox.Show("Successfuly saved the size changes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Declares what happens when resetToppingsButton button is clicked
        private void resetToppingsButton_Click(object sender, EventArgs e)
        {
            getToppingsFromFile();
            pizzaToppingsDataGridView.DataSource = new BindingList<PizzaTopping>(pizzaToppings);
        }

        // Function that gets the content of sizes file and stores it in the list
        void getSizesFromFile()
        {
            // Variable that holds the content from the json file that holds the pizza sizes
            var pizzaSizesInput = File.ReadAllText("pizzaSizesInputFile.json");

            // Gets the pizza sizes and stores them into a list of class objects
            pizzaSizes = JsonConvert.DeserializeObject<List<PizzaSize>>(pizzaSizesInput);
        }

        // Function that gets the pizzaSizes list content and serialize it to json type string
        void setSizesToFile()
        {
            // Creates a string that holds the sizes in json form
            string pizzaSizesJson = JsonConvert.SerializeObject(pizzaSizes);

            // Writes the above string in the file
            File.WriteAllText("pizzaSizesInputFile.json", pizzaSizesJson);
        }

        // Function that gets the content of toppings file and stores it in the list
        void getToppingsFromFile()
        {
            // Variable that holds the content from the json file that holds the pizza sizes
            var pizzaToppingsInput = File.ReadAllText("pizzaToppingsInputFile.json");

            // Gets the pizza sizes and stores them into a list of class objects
            pizzaToppings = JsonConvert.DeserializeObject<List<PizzaTopping>>(pizzaToppingsInput);
        }

        // Function that gets the pizzaToppings list content and serialize it to json type string
        void setToppingsToFile()
        {
            // Creates a string that holds the sizes in json form
            string pizzaToppingsJson = JsonConvert.SerializeObject(pizzaToppings);

            // Writes the above string in the file
            File.WriteAllText("pizzaToppingsInputFile.json", pizzaToppingsJson);
        }
    }
}
