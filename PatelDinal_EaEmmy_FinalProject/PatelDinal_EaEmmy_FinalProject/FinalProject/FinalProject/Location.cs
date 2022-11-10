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
    public partial class Location : Form
    {
        public Location(string title)
        {
            // Required for Windows Form Designer support
            InitializeComponent();

            Text = title; // set title text

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string street = streetTextBox.Text;
            string city = cityTextBox.Text;
            string province = provinceTextBox.Text;
            string postalCode = postalCodeTextBox.Text;
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");

                if(street != string.Empty)
                {
                    queryaddress.Append(street+","+"+");
                }

                if (city != string.Empty)
                {
                    queryaddress.Append(city + "," + "+");
                }

                if (province != string.Empty)
                {
                    queryaddress.Append(province + "," + "+");
                }

                if (postalCode != string.Empty)
                {
                    queryaddress.Append(postalCode + "," + "+");
                }

                webBrowser.Navigate(queryaddress.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error");

            }
        }
    }
}
