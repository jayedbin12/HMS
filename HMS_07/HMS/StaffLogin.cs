using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    public partial class StaffLogin : Form
    {
        private string username = "arman";
        private string password = "1234";
        private string Username = "jayed";
        private string Password = "4321";
        public StaffLogin()
        {
            InitializeComponent();
        }

        override protected void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }
        private void bttnlogin_Click(object sender, EventArgs e)
        {
            if(username==txtusername.Text && password==txtpassword.Text)
            {
                MessageBox.Show("Successful login");
                this.Hide();
                new StaffView().Show();
            }
            else if(Username==txtusername.Text && Password==txtpassword.Text)
            {
                MessageBox.Show("Successful login");
                this.Hide();
                new StaffView().Show();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmlogin().Show();
        }
    }
}
