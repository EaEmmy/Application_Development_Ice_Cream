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
    public partial class Command : Form
    {
        private static double Total { get; set; }
        public Command(string title)
        {
            InitializeComponent();

            Text = title; // set title text
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            var ctrl = flavourGroupBox;
            foreach (var checkBox in ctrl.Controls.OfType<CheckBox>())
            {
                Total = checkBox.Checked ? (Total + Convert.ToDouble(checkBox.Tag)) : Total;
            }

            var ctrl2 = toppingsGroupBox;
            foreach (var checkBox in ctrl2.Controls.OfType<CheckBox>())
            {
                Total = checkBox.Checked ? (Total + Convert.ToDouble(checkBox.Tag)) : Total;
            }

            var ctrl3 = containerGroupBox;
            foreach (var radioButton in ctrl3.Controls.OfType<RadioButton>())
            {
                Total = radioButton.Checked ? (Total + Convert.ToDouble(radioButton.Tag)) : Total;
            }

            // set output header
            string output = "Total Balance: \r\n";
            output += $"{Total:C}\r\n";
            receiptListBox.Items.Add(output);
        }

        public void ClearFlavours(GroupBox gbox)
        {
            foreach(Control ctrl in gbox.Controls)
            {
                CheckBox checkBox = (CheckBox)ctrl;
                checkBox.Checked = false;
            }
        }

        public void ClearToppings(GroupBox gbox)
        {
            foreach (Control ctrl in gbox.Controls)
            {
                CheckBox checkBox = (CheckBox)ctrl;
                checkBox.Checked = false;
            }
        }
        public void ClearContainers(GroupBox gbox)
        {
            foreach (Control ctrl in gbox.Controls)
            {
                RadioButton radioButton = (RadioButton)ctrl;
                radioButton.Checked = false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            receiptListBox.Items.Clear();
            Total = 0;
            ClearFlavours(flavourGroupBox);
            ClearToppings(toppingsGroupBox);
            ClearContainers(containerGroupBox);
        }

        private void clearButtonsButton_Click(object sender, EventArgs e)
        {
            ClearFlavours(flavourGroupBox);
            ClearToppings(toppingsGroupBox);
            ClearContainers(containerGroupBox);
        }

        private void bowlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bowlRadioButton.Checked)
            {
                receiptListBox.Items.Add(bowlRadioButton.Text + ": " +bowlRadioButton.Tag);
            }
        }

        private void coneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (coneRadioButton.Checked)
            {
                receiptListBox.Items.Add(coneRadioButton.Text + ": " + coneRadioButton.Tag);
            }
        }

        private void vanillaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vanillaCheckBox.Checked)
            {
                receiptListBox.Items.Add(vanillaCheckBox.Text + ": " + vanillaCheckBox.Tag);
            }
        }

        private void chocolateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chocolateCheckBox.Checked)
            {
                receiptListBox.Items.Add(chocolateCheckBox.Text + ": " + chocolateCheckBox.Tag);
            }
        }

        private void strawberryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (strawberryCheckBox.Checked)
            {
                receiptListBox.Items.Add(strawberryCheckBox.Text + ": " + strawberryCheckBox.Tag);
            }
        }

        private void cookieNCreamCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cookieNCreamCheckBox.Checked)
            {
                receiptListBox.Items.Add(cookieNCreamCheckBox.Text + ": " + cookieNCreamCheckBox.Tag);
            }
        }

        private void mintChocolateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mintChocolateCheckBox.Checked)
            {
                receiptListBox.Items.Add(mintChocolateCheckBox.Text + ": " + mintChocolateCheckBox.Tag);
            }
        }

        private void cookieDoughCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cookieDoughCheckBox.Checked)
            {
                receiptListBox.Items.Add(cookieDoughCheckBox.Text + ": " + cookieDoughCheckBox.Tag);
            }
        }

        private void pistachioCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pistachioCheckBox.Checked)
            {
                receiptListBox.Items.Add(pistachioCheckBox.Text + ": " + pistachioCheckBox.Tag);
            }
        }

        private void coffeeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (coffeeCheckBox.Checked)
            {
                receiptListBox.Items.Add(coffeeCheckBox.Text + ": " + coffeeCheckBox.Tag);
            }
        }

        private void mangoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mangoCheckBox.Checked)
            {
                receiptListBox.Items.Add(mangoCheckBox.Text + ": " + mangoCheckBox.Tag);
            }
        }

        private void matchaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (matchaCheckBox.Checked)
            {
                receiptListBox.Items.Add(matchaCheckBox.Text + ": " + matchaCheckBox.Tag);
            }
        }

        private void sprinklesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sprinklesCheckBox.Checked)
            {
                receiptListBox.Items.Add(sprinklesCheckBox.Text + ": " + sprinklesCheckBox.Tag);
            }
        }

        private void hotFudgeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hotFudgeCheckBox.Checked)
            {
                receiptListBox.Items.Add(hotFudgeCheckBox.Text + ": " + hotFudgeCheckBox.Tag);
            }
        }

        private void wCCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wCCheckBox.Checked)
            {
                receiptListBox.Items.Add(wCCheckBox.Text + ": " + wCCheckBox.Tag);
            }
        }

        private void nutsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (nutsCheckBox.Checked)
            {
                receiptListBox.Items.Add(nutsCheckBox.Text + ": " + nutsCheckBox.Tag);
            }
        }

        private void smartiesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (smartiesCheckBox.Checked)
            {
                receiptListBox.Items.Add(smartiesCheckBox.Text + ": " + smartiesCheckBox.Tag);
            }
        }

        private void chocoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chocoCheckBox.Checked)
            {
                receiptListBox.Items.Add(chocoCheckBox.Text + ": " + chocoCheckBox.Tag);
            }
        }

        private void caramelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (caramelCheckBox.Checked)
            {
                receiptListBox.Items.Add(caramelCheckBox.Text + ": " + caramelCheckBox.Tag);
            }
        }

        private void fruitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fruitCheckBox.Checked)
            {
                receiptListBox.Items.Add(fruitCheckBox.Text + ": " + fruitCheckBox.Tag);
            }
        }

        private void gummyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gummyCheckBox.Checked)
            {
                receiptListBox.Items.Add(gummyCheckBox.Text + ": " + gummyCheckBox.Tag);
            }
        }

        private void cherryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cherryCheckBox.Checked)
            {
                receiptListBox.Items.Add(cherryCheckBox.Text + ": " + cherryCheckBox.Tag);
            }
        }
    }
}
