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

        public LoginPage()
        {
            InitializeComponent();
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("login.txt");
            String[] fileLines = File.ReadAllLines("login.txt");

            int length = File.ReadAllLines("login.txt").Length;
            string[,] loginCred = new string[length, 3];
            string[] userNames = new string[length];


            FileInfo loginFile = new FileInfo("login.txt");


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
                            userNames[y] = fileLines[y].Split(',')[x]; ;
                        }

                    }

                }



                int pos = Array.IndexOf(userNames, username); //Gets the position of where that string is in the array
                if(pos < 0)
                {
                    MessageBox.Show("Username not found");
                }
                else
                {
                    if(loginCred[pos,1] != password)
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
