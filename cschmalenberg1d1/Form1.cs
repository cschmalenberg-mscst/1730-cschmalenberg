using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cschmalenberg1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       

        private void txtRateAustralia_TextChanged(object sender, EventArgs e)
        {
          

      
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                99.99m
                ).ToString("0.00");
        }

        private void txtUSDAustralia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUSDBhutanese_TextChanged(object sender, EventArgs e)
        {
            txtUSDBhutanese.Text = (
               Convert.ToDecimal(txtAmountBhutanese.Text) * Convert.ToDecimal(txtRateBhutanese.Text)
                ).ToString("0.00");
        }

        private void txtUSDCostaRica_TextChanged(object sender, EventArgs e)
        {
            txtUSDCostaRica.Text = (
               Convert.ToDecimal(txtAmountCostaRica.Text) * Convert.ToDecimal(txtRateCostaRica.Text)
                ).ToString("0.00");
        }

        private void txtUSDEuro_TextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
               Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)
                ).ToString("0.00");
        }

        private void txtTotalUSD_TextChanged(object sender, EventArgs e)
        {

        }
    }

       
        

        }
    

    
    }
