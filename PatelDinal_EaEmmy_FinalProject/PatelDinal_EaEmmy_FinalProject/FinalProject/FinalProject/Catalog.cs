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
    public partial class Catalog : Form
    {
        private int ImageNumber { get; set; } = -1; // image to display
        public Catalog(string title)
        {
            // Required for Windows Form Designer support
            InitializeComponent();

            Text = title; // set title text

        }

        private void catalogPictureBox_Click(object sender, EventArgs e)
        {
            catalogPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            ImageNumber = (ImageNumber + 1) % 10; // cycles from 0 to 10

            // retrieve image from resources and load into PictureBox
            if (ImageNumber < 10)
            {
                catalogPictureBox.Image =
                (Image)(Properties.Resources.ResourceManager.GetObject($"image{ImageNumber}"));
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {

            ImageNumber = (ImageNumber - 1) % 10; // cycles from 0 to 10
            if(ImageNumber < 0)
            {
                ImageNumber = 9;
            }

            // retrieve image from resources and load into PictureBox
            if (ImageNumber < 10)
            {
                catalogPictureBox.Image =
            (Image)(Properties.Resources.ResourceManager.GetObject($"image{ImageNumber}"));
            }
        }
    }
}

