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
    public partial class StaffDatabase : Form
    {
        public StaffDatabase()
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

        private static string connectionstring = @"Server=LAPTOP-35V804DV;Database=db_Staff;Integrated Security=true;";
        private static SqlConnection connection = new SqlConnection(connectionstring);

        private void bttnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmlogin().Show();
        }

        private void bttninsert_Click(object sender, EventArgs e)
        {
            string username = txtname.Text.Trim();
            string gender = Text.Trim();
            if (radioButtonmale.Checked)
            {
                gender = radioButtonmale.Text.Trim();
            }
            else if (radioButtonfemale.Checked)
            {
                gender = radioButtonfemale.Text.Trim();
            }
            string email = txtemail.Text.Trim();
            string phone = txtphone.Text.Trim();
            string Dutyday = txtdutyday.Text.Trim();
            string Dutytime = txtdutytime.Text.Trim();
            string Dutyfloor = txtdutyfloor.Text.Trim();
            string salary = txtsalary.Text.Trim();

            if (phone.Length == 0 || username.Length == 0 || email.Length == 0 || Dutyday.Length == 0 || Dutytime.Length == 0)
                return;

            string query = String.Format("INSERT INTO Staff VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}');", username, phone, email, gender, Dutyday, Dutytime, Dutyfloor, salary);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            int numberOfRowsEffect = cmd.ExecuteNonQuery();

            connection.Close();

            if (numberOfRowsEffect > 0)
                MessageBox.Show("Insert Successful");
        }

        private void bttndelete_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();

            if (name.Length == 0)
                return;

            string query = String.Format("DELETE FROM Staff WHERE Name = '{0}';", name);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            int numberOfRowsEffect = cmd.ExecuteNonQuery();

            connection.Close();

            if (numberOfRowsEffect > 0)
                MessageBox.Show("Delete successfully");
        }

        private void bttnsearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Staff WHERE Name='" + txtsearch.Text + "'";
            DataTable dt = new DataTable();

            connection.Open();

            SqlDataAdapter dtaAdapter = new SqlDataAdapter(query, connection);
            dtaAdapter.Fill(dt);

            dgvstaff.DataSource = dt;

            connection.Close();
        }

        private void bttnshow_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Staff";
            DataTable dt = new DataTable();

            connection.Open();

            SqlDataAdapter dtaAdapter = new SqlDataAdapter(query, connection);
            dtaAdapter.Fill(dt);

            dgvstaff.DataSource = dt;

            connection.Close();
        }

        private void bttnedit_Click(object sender, EventArgs e)
        {
            string ID = txtid.Text.Trim();
            string username = txtname.Text.Trim();
            string gender = Text.Trim();
            if (radioButtonmale.Checked)
            {
                gender = radioButtonmale.Text.Trim();
            }
            else if (radioButtonfemale.Checked)
            {
                gender = radioButtonfemale.Text.Trim();
            }
            string email = txtemail.Text.Trim();
            string phone = txtphone.Text.Trim();
            string Dutyday = txtdutyday.Text.Trim();
            string Dutytime = txtdutytime.Text.Trim();
            string Dutyfloor = txtdutyfloor.Text.Trim();
            string salary = txtsalary.Text.Trim();

            if (phone.Length == 0 || username.Length == 0 || email.Length == 0 || Dutyday.Length == 0 || Dutytime.Length == 0)
                return;

            string query = String.Format("UPDATE Staff SET Name='{0}', Phone='{1}', Email='{2}', Gender='{3}', DutyDay='{4}', DutyTime='{5}', DutyFloor='{6}', Salary='{7}' WHERE ID={8};", username, phone, email, gender, Dutyday, Dutytime, Dutyfloor, salary, ID);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            int numberOfRowsEffect = cmd.ExecuteNonQuery();

            connection.Close();

            if (numberOfRowsEffect > 0)
                MessageBox.Show("Update Successful");
        }

        private void adminPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin().Show();
        }
    }
}
