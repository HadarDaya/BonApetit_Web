using System;
using Bon_Apetit.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bon_Apetit.FrontEnd.UserControls;

namespace Bon_Apetit.Forms
{
    public partial class AdminLogIn : Form
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Checks the conditons for log in as admin
        private void LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Password.Text == string.Empty)
                {
                    MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (Password.Text != "12345")
                {
                    MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // The password is correct- Admin
                {
                    AdminEditing ed = new AdminEditing();
                    ed.ShowDialog();
                    this.Hide();
                    ed.Show();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void AdminLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
