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
    public partial class StartPage : Form
    {
        bool create = false;

        public StartPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            create = false;
            this.Hide();
            LoginPage f2 = new LoginPage();
            f2.Show();
        }

        private void createAccbtn_Click(object sender, EventArgs e)
        {
            create = true;
            this.Hide();
            LoginPage f2 = new LoginPage();
            f2.Show();
        }
    }
}
