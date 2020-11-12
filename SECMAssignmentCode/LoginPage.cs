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
        public static string[,] loginCred = new string[length, 3];
        public static string[] userNames = new string[length];


        public LoginPage()
        {
            InitializeComponent();
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            
            String[] fileLines = File.ReadAllLines("login.txt");



            string username = usernametb.Text;
            string password = passwordtb.Text;


            if ((usernametb.Text == "") || (passwordtb.Text == ""))
            {
                MessageBox.Show("Invalid login informatin");
            }
            else
            {
                for (int y = 0; y < length; y++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        loginCred[y,x] = fileLines[y].Split(',')[x];

                        if(x ==0)
                        {
                            userNames[y] = fileLines[y].Split(',')[x]; // Adds the username to a list of usernames
                            int mod = Convert.ToInt32(loginCred[y, 2]);
                            User newUser = new User(loginCred[y, 0], loginCred[y, 1], mod); // Creates a new object for the user and passes in the username, password and either a 1/0 depending on if that user has admin powers
                        }

                    }

                }

                

                int pos = Array.IndexOf(userNames, username); //Gets the position of where that string is in the array
                if(pos < 0) // Pos will be -1 if the array does not contain the username
                {
                    MessageBox.Show("Username not found");
                }
                else
                {
                    if(loginCred[pos,1] != password) // Checks if the password is correct
                    {
                        MessageBox.Show("Incorrect Password");
                    }
                    else
                    {
                         if(loginCred[pos,2] == "0")
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
