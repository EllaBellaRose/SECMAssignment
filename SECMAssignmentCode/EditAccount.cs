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


            if (MenuPage.add == true)
            {
                // Code for adding an account



                StreamReader reader = new StreamReader("login.txt");
                String[] fileLines = File.ReadAllLines("login.txt");

                int length = File.ReadAllLines("login.txt").Length;
                string[,] loginCred = new string[length, 3];
                string[] userNames = new string[length];


                FileInfo loginFile = new FileInfo("login.txt");


                string username = usernametb.Text;
                string password = passwordtb.Text;


                if ((usernametb.Text == "") || (passwordtb.Text == "")&& (yesModcb.Checked)||(noModcb.Checked) && !((yesModcb.Checked) && (noModcb.Checked)))
                {
                    MessageBox.Show("Invalid login informatin");
                }
                else
                {
                    for (int y = 0; y < length; y++)
                    {
                        for (int x = 0; x < 3; x++)
                        {
                            loginCred[y, x] = fileLines[y].Split(',')[x];
                            if (x == 0)
                            {
                                userNames[y] = fileLines[y].Split(',')[x]; ;
                            }

                        }

                    }



                    int pos = Array.IndexOf(userNames, username); //Gets the position of where that string is in the array
                    if (pos < 0)
                    {
                        // Not in the list so can add it

                        FileInfo newSave = new FileInfo("login.txt");

                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(newSave))
                        {

                        }



                    }
                    else
                    {
                        // Already in the login page

                        MessageBox.Show("An account with this username already exists");
                        usernametb.Text = "";
                        passwordtb.Text = "";
                        yesModcb.Checked = false;
                        noModcb.Checked = false;

                    }

                }
            }

            else
            {
                // Code for deleting an account





            }
        }
    }
}
