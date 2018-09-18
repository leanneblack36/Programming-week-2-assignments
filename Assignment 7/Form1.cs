using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // input start and end km//
            //read start km entered//
            string input1 = txtStartkm.Text;
            double Startkm = double.Parse(input1);

            //read end km entered//
            string input2 = txtEndkm.Text;
            double Endkm = double.Parse(input2);

            //read price per km//
            string input3 = txtPricekm.Text;
            double Pricekm = double.Parse(input3);
             
            //Calculate km's clocked = endkm - startkm//
            double TotalKM = Endkm - Startkm;

            //Calculate Price excl VAT//
            double PriceexclVAT = TotalKM * 0.25;

            //Calculate VAT//
            double VAT = PriceexclVAT * 0.21;

            //Calculate Price incl VAT//
            double PriceincVAT = PriceexclVAT + VAT;

            //Output price excl VAT, VAT and Price Incl VAT//
           lblPriceexVAT.Text = PriceexclVAT.ToString("0.00");
           lblShowVAT.Text = VAT.ToString("0.00");
           lblPriceincVAT.Text = PriceincVAT.ToString("0.00"); 
            



        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            txtStartkm.Text = string.Empty;
            txtEndkm.Text = string.Empty;
            txtPricekm.Text = string.Empty;
            lblPriceexVAT.Text = string.Empty;
            lblShowVAT.Text = string.Empty;
            lblPriceincVAT.Text = string.Empty;
        }
    }
}
