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
    public partial class ContactUs : Form
    {
        public ContactUs(string title)
        {
            // Required for Windows Form Designer support
            InitializeComponent();

            Text = title; // set title text
        }
    }
}
