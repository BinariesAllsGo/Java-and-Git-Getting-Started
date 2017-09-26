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
    public partial class formCalculator : Form
    {

        double result = 0;
        char operation;

        public formCalculator()
        {
            InitializeComponent();
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            result = 0;
            txtResult.Text = string.Empty;
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += "1";
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += "2";
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += "3";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            operation = '+';
            result = double.Parse(this.txtResult.Text);
            this.txtResult.Text = string.Empty;
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += "4";
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += "5";
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += "6";
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            operation = '-';
            result = double.Parse(this.txtResult.Text);
            this.txtResult.Text = string.Empty;
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += "7";
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += "8";
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += "9";
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            operation = '*';
            result = double.Parse(this.txtResult.Text);
            this.txtResult.Text = string.Empty;

        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            this.txtResult.Text += "0";
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtResult.Text))
            {
                double valor = double.Parse(this.txtResult.Text);
                switch (operation)
                {
                    case '+':
                        result += valor;
                        break;
                    case '-':
                        result -= valor;
                        break;
                    case '*':
                        result *= valor;
                        break;
                    case '/':
                        result /= valor;
                        break;
                }
           }
           this.txtResult.Text = result.ToString();

        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            operation = '/';
            result = double.Parse(this.txtResult.Text);
            this.txtResult.Text = string.Empty;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
