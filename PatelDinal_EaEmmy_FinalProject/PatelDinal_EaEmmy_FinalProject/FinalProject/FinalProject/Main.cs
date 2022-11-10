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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void preorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create new child
            var child = new Calendar(
            "Preorder");
            child.MdiParent = this; // set parent 
            child.Show(); // display child 
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new Catalog(
                       "Items");
            child.MdiParent = this; // set parent 
            child.Show(); // display child 
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new Location(
                     "Map");
            child.MdiParent = this; // set parent 
            child.Show(); // display child 
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ContactUs(
                    "Information");
            child.MdiParent = this; // set parent 
            child.Show(); // display child 
        } 
        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new Command(
                  "Order");
            child.MdiParent = this; // set parent 
            child.Show(); // display child 
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new Language(
                "Change");
            child.MdiParent = this; // set parent 
            child.Show(); // display child 
        }


        private void cascadeToolStripMenuItem_Click(
        object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromArgb(229, 255, 204);
                }
            }
        }
    }
}
