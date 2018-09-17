using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Assignment4 : Form
    {
        const double VAT = 0.21;
        public Assignment4()
        {
            InitializeComponent();
        }
        
    
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // input price//
            //read price entered//
            string input = txtEnterPrice.Text;
            //convert string to double
            double EnterPrice = double.Parse(input);
        
            //calculate VAT

             double tax = (EnterPrice * VAT);

            // Calculate the total//

            Double totalprice = EnterPrice + tax; 

            //show price, VAT & total price in text boxes

            txtDisplayPrice.Text = EnterPrice.ToString();
            txtShowVAT.Text = tax.ToString();
            txtTotal.Text = totalprice.ToString();

            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Assignment4_Load(object sender, EventArgs e)
        {

        }
    }
}
