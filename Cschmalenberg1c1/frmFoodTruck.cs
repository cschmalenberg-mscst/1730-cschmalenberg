using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cschmalenberg1c1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = (
                4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");
            txtHamburgersSubtotal.Text = (
                5.0m * Convert.ToDecimal(txtHamburgers.Text)
                ).ToString("0.00");
            txtPretaxTotal.Text = (
               Convert.ToDecimal(txtHotDogsSubtotal.Text)
               + Convert.ToDecimal(txtHamburgersSubtotal.Text)
                ).ToString("0.00");
            txtTax.Text = (
                .06875m * Convert.ToDecimal(txtPretaxTotal.Text)
                ).ToString("0.00");
            btnClear.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.HotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "0";
            txtHamburgersSubtotal.Text = "0";
            txtPretaxTotal.Text = "0";
            txtTax.Text = "0";
            txtTotal.Text = "0";
            txtHotDogs.Focus();
        }
    }
}
