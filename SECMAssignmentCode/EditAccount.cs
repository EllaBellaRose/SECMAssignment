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

        private void donedeladdbtn_Click(object sender, EventArgs e)
        {
            string username = usernametb.Text;

            if (MenuPage.add == true)
            {
                // Code for adding an account

                // TODO: Fix it so when you create a user you can log out then log back in with the details of the new user just made
                // It writes it to the textfile but isnt being recognised by the loginCred[,] or userNames[]

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

                if ((validUserName()) && (passwordtb.Text != "")&& ((yesModcb.Checked) || (noModcb.Checked)))
                {
                    // Validates so that the textboxes are not empty and one of the check boxes are selected

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


                        User newUser = new User(username, password, mod); //Created the object and add it to the arrays
                        loginCred[length, 0] = username;
                        loginCred[length, 1] = password;
                        loginCred[length, 2] = mod.ToString();
                        userNames[length] = username;


                        using (System.IO.StreamWriter file = new System.IO.StreamWriter("login.txt", true))
                        {
                            file.WriteLine(username + "," + password + "," + mod); // This adds the user to the textfile in the same format as all of the other data
                        }

                        MessageBox.Show("Successfully added user: " + username + " to the system");
                        // Add was sucessfull so clear all of the data on the page (username, password and the checkboxoes)
                        clearData();


                    }
                    else
                    {
                        // Already in the login textfile
                        // This deletes any of the text in either textbox and unchecks the checkboxes
                        MessageBox.Show("An account with this username already exists");
                        clearData();
                    }
                }           
                else
                {
                    MessageBox.Show("Error");
                    clearData();
                }
            }
            else
            {
                // Code for deleting an account


            if(usernametb.Text != "")
                {

                    int pos = Array.IndexOf(LoginPage.userNames, username); // Gets the position of where that string is in the array
                    if (pos < 0) // Does not exist
                    {
                        MessageBox.Show("This user does not exist");

                    }
                    else /// Does exist
                    {
                        MessageBox.Show("You have successfully deleted the account: " + usernametb.Text);

                        string account = usernametb.Text; // Assigns the username to this variable
                        var oldLines = System.IO.File.ReadAllLines("login.txt"); // Reads all the lines in the login textfile
                        var newLines = oldLines.Where(line => !line.Contains(account)); // Selects the line that the username is on
                        System.IO.File.WriteAllLines("login.txt", newLines); // Writes over that line with blank so deletes it
                        FileStream obj = new FileStream("login.txt", FileMode.Append);
                        obj.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid username");
                    usernametb.Text = "";
                }
            }
        }

        private bool validUserName()
        {
            if(usernametb.Text == "")
            {
                return false;
            }
            else
            {
                if(usernamelb.Text.Length != 8)
                {
                    MessageBox.Show("The Username needs to be 8 characters long");
                    return false;
                }
                else
                {
                    return true;
                }
            }
           
        }

        private void yesModcb_CheckedChanged(object sender, EventArgs e)
        {
            if ((yesModcb.Checked) && (noModcb.Checked))
            {
                yesModcb.Checked = false;
            }

        }

        private void noModcb_CheckedChanged(object sender, EventArgs e)
        {
            if ((yesModcb.Checked) && (noModcb.Checked))
            {
                noModcb.Checked = false;
            }
        }

        private void clearData()
        {
            usernametb.Text = "";
            passwordtb.Text = "";
            yesModcb.Checked = false;
            noModcb.Checked = false;
        }
    }
}
