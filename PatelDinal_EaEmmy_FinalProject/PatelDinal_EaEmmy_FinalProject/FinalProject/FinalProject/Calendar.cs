using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Calendar : Form
    {
        public Calendar(string title)
        {
            // Required for Windows Form Designer support
            InitializeComponent();

            Text = title; // set title text
        }

        private void pickUpDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            String hourMinute = DateTime.Now.ToString("HH:mm");
           // DateTime pickUpDate = pickUpDateTimePicker.Value;
            outputLabel.Text = "Ready on opening hour";
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            // user cannot select days before today
            pickUpDateTimePicker.MinDate = DateTime.Today;
            // user can only select days up to one year in the future
            pickUpDateTimePicker.MaxDate = DateTime.Today.AddYears(1);
        }
    }
}
