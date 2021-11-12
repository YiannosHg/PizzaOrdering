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
        // Variables
        int userID = CurrentUser.currentUserID;

        // Lists of pizzaSizes and pizzaToppings
        List<PizzaSize> pizzaSizes = new List<PizzaSize>();
        List<PizzaTopping> pizzaToppings = new List<PizzaTopping>();
        List<User> users = new List<User>();

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        { 
            getSizesFromFile();
            getToppingsFromFile();
            getUsersFromFile();
            checkUserAccessRights();
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

        // Declares what happens when saveUsersButton is clicked
        private void saveUsersButton_Click(object sender, EventArgs e)
        {
            setUsersToFile();
            MessageBox.Show("Successfuly saved the users changes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Declares what happens when resetUsersButton is clicked
        private void resetUsersButton_Click(object sender, EventArgs e)
        {
            getUsersFromFile();
            usersDataGridView.DataSource = new BindingList<User>(users);
        }

        // Function that gets the content of sizes file and stores it in the list
        void getSizesFromFile()
        {
            // Variable that holds the content from the json file that holds the pizza sizes
            var pizzaSizesInput = File.ReadAllText("pizzaSizesInputFile.json");

            // Gets the pizza sizes and stores them into a list of class objects
            pizzaSizes = JsonConvert.DeserializeObject<List<PizzaSize>>(pizzaSizesInput);

            // Sets the source of data to be shown in DataGridView
            pizzaSizeDataGridView.DataSource = new BindingList<PizzaSize>(pizzaSizes);
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

            // Sets the source of data to be shown in DataGridView
            pizzaToppingsDataGridView.DataSource = new BindingList<PizzaTopping>(pizzaToppings);
        }

        // Function that gets the pizzaToppings list content and serialize it to json type string
        void setToppingsToFile()
        {
            // Creates a string that holds the toppings in json form
            string pizzaToppingsJson = JsonConvert.SerializeObject(pizzaToppings);

            // Writes the above string in the file
            File.WriteAllText("pizzaToppingsInputFile.json", pizzaToppingsJson);
        }

        // Function that gets the content of users file and stores it in the list
        void getUsersFromFile()
        {
            // Variable that holds the content from the json file that holds the users
            var usersInput = File.ReadAllText("usersInputFile.json");

            // Gets the users and stores them into a list of class objects
            users = JsonConvert.DeserializeObject<List<User>>(usersInput);

            // Sets the source of data to be shown in DataGridView
            usersDataGridView.DataSource = new BindingList<User>(users);
        }

        // Function that gets the users list content and serialize it to json type string
        void setUsersToFile()
        {
            // Creates a string that holds the users in json form
            string usersJson = JsonConvert.SerializeObject(users);

            // Writes the above string in the file
            File.WriteAllText("usersInputFile.json", usersJson);
        }

        // Checks if the current user has access to edit a list, if not that list is disabled
        void checkUserAccessRights()
        {
            if (false == users[userID].CanEditSizes)
                sizesGroupBox.Enabled = false;
            if (false == users[userID].CanEditToppings)
                toppingsGroupBox.Enabled = false;
            if (false == users[userID].CanEditUsers)
                usersGroupBox.Enabled = false;
        }
    }
}
