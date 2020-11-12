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
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            if (MenuPage.add == true)
            {
                addlb.Show();
                passwordtb.Show();
                passwordlb.Show();
                yesModcb.Show();
                noModcb.Show();

            }
            else
            {
                dellb.Show();
            }


        }

        private void backToMenubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPage f3 = new MenuPage();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernametb.Text;

            if (MenuPage.add == true)
            {
                // Code for adding an account

                int length = File.ReadAllLines("login.txt").Length;
                string[,] loginCred = new string[length+1, 3];
                string[] userNames = new string[length+1];


               
                string password = passwordtb.Text;
                int mod;


                // To be valid it needs
                // Text in the username
                // Text in the password
                // One of the checkboxes checked
                // But not both

                if ((usernametb.Text != "") || (passwordtb.Text != "")&& ((yesModcb.Checked) || (noModcb.Checked)))
                {


                    if(yesModcb.Checked)
                    {
                        mod = 1;
                    }
                    else
                    {
                        mod = 0;
                    }
                  
                    int pos = Array.IndexOf(LoginPage.userNames, username); //Gets the position of where that string is in the array
                    if (pos < 0)
                    {
                        // Not in the list so can add it


                        User newUser = new User(username, password, mod); //Created the object and add it to the array
                        LoginPage.loginCred[length, 0] = username;
                        LoginPage.loginCred[length, 1] = password;
                        LoginPage.loginCred[length, 2] = mod.ToString();
                        LoginPage.userNames[length] = username;


                        using (System.IO.StreamWriter file = new System.IO.StreamWriter("login.txt", true))
                        {
                            file.WriteLine(username + "," + password + "," + mod);
                        }

                        MessageBox.Show("Successfully added user: " + username + " to the system");
                        usernametb.Text = "";
                        passwordtb.Text = "";
                        yesModcb.Checked = false;
                        noModcb.Checked = false;


                    }
                    else
                    {
                        // Already in the login textfile

                        MessageBox.Show("An account with this username already exists");
                        usernametb.Text = "";
                        passwordtb.Text = "";
                        yesModcb.Checked = false;
                        noModcb.Checked = false;

                    }

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

            else
            {
                // Code for deleting an account


            if(usernametb.Text != "")
                {

                    int pos = Array.IndexOf(LoginPage.userNames, username); //Gets the position of where that string is in the array
                    if (pos < 0) // Does not exist
                    {
                        MessageBox.Show("This user does not exist");

                    }
                    else /// Does exist
                    {







                    }




                }
                else
                {
                    MessageBox.Show("Please enter a valid username");
                }











            }
        }
    }
}
