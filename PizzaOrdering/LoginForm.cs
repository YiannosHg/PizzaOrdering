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
    // Static class that holds the loggedin user
    public static class CurrentUser
    {
        public static int currentUserID;
    }

    // Static class that holds a bool variable to check if a user is loggedin
    public static class LoggedIn
    {
        public static bool isLoggedIn = false;
    }

    public partial class LoginForm : Form
    {
        // List of Users
        List<User> users = new List<User>();
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            getUsersFromFile();
        }

        // Declares what happens when login button is clicked
        private void loginButton_Click(object sender, EventArgs e)
        {
            // if user exists then load PizzaOrderingForm, else show error message
            if (checkUsersCredentials())
            {
                this.Close();
                LoggedIn.isLoggedIn = true;
            }
        }

        private void getUsersFromFile()
        {
            string inputFile = "usersInputFile.json";

            if (!File.Exists(inputFile)) // Check if file exists
            {
                // if it does not exist create file with one user entry as default
                User admin = new User("Admin", "Admin", true, true, true);
                users.Add(admin);

                // Creates a string that holds the users in json form
                string usersJson = JsonConvert.SerializeObject(users);

                // Writes the above string in the file
                File.WriteAllText(inputFile, usersJson);
            }

            // Variable that holds the content from the json file that holds the users
            var usersInput = File.ReadAllText(inputFile);

            // Gets the users and stores them into a list of class objects
            users = JsonConvert.DeserializeObject<List<User>>(usersInput);
        }

        // Function that checks if the given credentials match a user entry
        // and return user's position in the Users List
        private bool checkUsersCredentials()
        {
            if (String.IsNullOrEmpty(usernameTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Username or Password is invalid", "Login error");
                return false;
            }
            else 
            {
                for (int i=0; i<users.Count; ++i)
                {
                    if (usernameTextBox.Text == users[i].Name && passwordTextBox.Text == users[i].Password)
                    {
                        CurrentUser.currentUserID = i;
                        return true;
                    }
                }
            }
            MessageBox.Show("User does not exist", "Login error");
            return false;
        }
    }
}
