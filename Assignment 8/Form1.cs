using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //constant//

            const int Tshirtsprice = 30;
            const int Jeansprice = 100;

            //input//
            //read number of jeans and tshirts//
            string input1 = txtTshirts.Text;
            int Tshirts = int.Parse(input1);

            string input2 = txtJeans.Text;
            int Jeans = int.Parse(input2);


            //Calculate Price excl VAT//
            double Price = (Tshirts * Tshirtsprice) + (Jeans * Jeansprice);

            //Calculate VAT//
            double VAT = Price * 0.21;

            //Calculate Price incl VAT//
            double Totalprice = Price + VAT;

            //Output price excl VAT, VAT and Price Incl VAT//
            lblPrice.Text = Price.ToString("€0.00");
            lblVAT.Text = VAT.ToString("€0.00");
            lblTotalprice.Text = Totalprice.ToString("€0.00");

           
        }
    }
}
