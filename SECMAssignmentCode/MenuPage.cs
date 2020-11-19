using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SECMAssignmentCode
{
    public partial class MenuPage : Form
    {
        public static bool add = false;

        public MenuPage()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backToLoginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage f2 = new LoginPage();
            f2.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(LoginPage.hasAuthority == true) // If the user is a mod then the option to delete and add an account appears, if they are not a mod they don't appear
            {
                addAccbtn.Show();
                delAccbtn.Show();
            }
        }

        private void addAccbtn_Click(object sender, EventArgs e)
        {
            add = true;
            this.Hide();
            EditAccount f4 = new EditAccount();
            f4.Show();
        }

        private void delAccbtn_Click(object sender, EventArgs e)
        {
            add = false;
            this.Hide();
            EditAccount f4 = new EditAccount();
            f4.Show();
        }

        private void prefbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrefEx f5 = new PrefEx();
            f5.Show();
        }
    }
}
