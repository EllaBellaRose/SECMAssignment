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

namespace SECMAssignmentCode
{
    public partial class LoginPage : Form
    {
        public static bool hasAuthority = false;
        public static int length = File.ReadAllLines("login.txt").Length;
        public static string[,] loginCred = new string[length, 4];
        public static string[] userNames = new string[length];
        public static string userName;
        private static List<User> userList = new List<User>();


        public LoginPage()
        {
            InitializeComponent();
        }

        internal static List<User> UserList { get => userList; set => userList = value; }

        private void donebtn_Click(object sender, EventArgs e)
        {
            // This is called when the Done nutton to log in is pressed


            String[] fileLines = File.ReadAllLines("login.txt"); //The text file all the login details are

            string username = usernametb.Text;
            string password = passwordtb.Text;
            userName = username;


            if ((usernametb.Text == "") || (passwordtb.Text == "")) // Validation that both text boxes in the form are not empty
            {
                MessageBox.Show("Invalid login informatin");
            }
            else
            {
                for (int y = 0; y < length; y++) // This for loop goes through the text file and splits all the data up by a comma
                {
                    for (int x = 0; x < 3; x++)
                    {
                        loginCred[y,x] = fileLines[y].Split(',')[x]; // After splitting the data it is added into an array in the same x,y

                        if(x ==0) // This is only for the first collumn which is the username
                        {
                            userNames[y] = fileLines[y].Split(',')[x]; // Adds the username to a list of usernames
                            int mod = Convert.ToInt32(loginCred[y, 2]); /// mod is if the user has modicfication access (teacher / ability to add and delete accounts / able to arrange meetings)
                            User newUser = new User(loginCred[y, 0], loginCred[y, 1], mod); // Creates a new object for the user and passes in the username, password and either a 1/0 depending on if that user has admin powers
                            UserList.Add(newUser);
                        }

                    }

                }

                

                int pos = Array.IndexOf(userNames, username); //Gets the position of where that string is in the array
                if(pos < 0) // Pos will be -1 if the array does not contain the username
                {
                    MessageBox.Show("Username not found");
                }
                else // If pos == 1 or more then the textfile contains it
                {
                    if(loginCred[pos,1] != password) // Checks if the password is correct
                    {
                        MessageBox.Show("Incorrect Password");
                    }
                    else
                    {
                     
                            if(loginCred[pos,2] == "0") // Checking if the user is a mod or not
                            {
                                hasAuthority = false;
                            }
                            else
                            {
                                hasAuthority = true;
                            }
                            MessageBox.Show("Successful login");

                            this.Hide();
                            MenuPage f3 = new MenuPage();
                            f3.Show();
                   
                    }
                }
            }
        }
    }
}
