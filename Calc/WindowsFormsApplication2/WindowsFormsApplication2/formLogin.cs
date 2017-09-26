using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class formLogin : Form
    {
        Form frmCalculator = new formCalculator();

        public formLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text == "admin") && (txtPassword.Text == "password"))
            {

                frmCalculator.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Incorrect Login or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLogin.Text = "";
                txtPassword.Text = "";
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Login: admin\nPassword: password", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
