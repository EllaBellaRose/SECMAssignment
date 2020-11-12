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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void srtpgbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartPage f1 = new StartPage();
            f1.Show();
        }
    }
}
