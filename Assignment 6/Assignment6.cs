using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Assignment6 : Form
    {
        public Assignment6()
        {
            InitializeComponent();
        }

        private void btnCalculateTime_Click(object sender, EventArgs e)
        {
            // input seconds//
            //read numbers entered//
            string input = txtEnteredSeconds.Text;
            int EnteredSeconds = int.Parse(input);


            //work out how many hours in entered seconds = ES / 3600

            int hours = (EnteredSeconds / 3600);

            //work out how many seconds are in the hours
            int numberOfSecondsLeft = (hours * 3600);

            //now subrtact the seconds in the hours away from the entered seconds to see the remaining seconds
            int remainingSeconds = EnteredSeconds - numberOfSecondsLeft;

            //work out how many minutes are in those remaining seconds
            int minutes = remainingSeconds / 60;

            //now find out how many seconds are left
            int endseconds = EnteredSeconds - ((hours * 3600) + (minutes * 60));

            //display the time in digital format hh:mm:ss


            string hoursStr = hours.ToString("D2");
            string minutesStr = minutes.ToString("D2");
            string secondsStr = endseconds.ToString("D2");


            lblFinal.Text = hoursStr +":" + minutesStr + ":" + secondsStr;
         
        }
    }
}
