using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class Assignment5 : Form
    {
        public Assignment5()
        {
            InitializeComponent();
        }

        private void txtNo1_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // input seconds//
            //read seconds entered//
            string input = txtOne.Text;
            Double One = Double.Parse(input);

            string input2 = txtTwo.Text;
            Double Two = Double.Parse(input2);

            string input3 = txtThree.Text;
            Double Three = Double.Parse(input3);

            ////Calculate average of the three numbers//

            Double total = (One + Two + Three);
            Double average = total / 3;

            //show average of the three numbers//
            txtAverage.Text = average.ToString();
        }
    }
}
