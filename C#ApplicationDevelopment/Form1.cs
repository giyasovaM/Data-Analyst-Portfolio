// Programmer: Madinakhon Giyasova
// Project: Lab 3-1
// Date: 03/05/2021
// Description: Form for taking a pet care order.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        // Declare class-level constants for later use in the program
        private const decimal FLEA_REMOVAL_PRICE = 5.00m;
        private const decimal NAIL_CLIPPING_PRICE = 4.50m;
        private const decimal SHAMPOO_PRICE = 4.00m;
        private const decimal FUR_TRIMMING_PRICE = 9.00m;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void petDOBMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void petNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void petGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void dogRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void otherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Manage the situation when the "Other" radio button is selected/deselected
            // Note: In design view, the typeIfOtherLabel control ad the typeIfOtherTextBox
            // control had initial values of False set for the Enabled property
            if (otherRadioButton.Checked)
            {
                typeIfOtherLabel.Enabled = true;
                typeIfOtherTextBox.Enabled = true;
                typeIfOtherTextBox.Focus();
            }
            else
            {
                typeIfOtherLabel.Enabled = false;
                typeIfOtherTextBox.Enabled = false;
                typeIfOtherTextBox.Text = ""; // Clear contents of this control
            }
        }

        private void typeIfOtherTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Handle Total button's click event
        // (Calculate and display the total fee for the order)
        private void totalButton_Click(object sender, EventArgs e)
        {
            // Declare and innitialize local variable used to store total fee
            decimal totalFee = 0.00m;

            // Use if blocks to permorf calculations necessary to determine the total
            // For each check box that is checked, add that service price total
            if (fleaRemovalCheckBox.Checked)
            {
                totalFee += FLEA_REMOVAL_PRICE;
            }
            if ( nailClippingCheckBox.Checked)
            {
                totalFee += NAIL_CLIPPING_PRICE;
            }
            if(shampooCheckBox.Checked)
            {
                totalFee += SHAMPOO_PRICE;
            }
            if (furTrimmingCheckBox.Checked)
            {
                totalFee += FUR_TRIMMING_PRICE;
            }

            // Display the total dee in label, formatted as currency
            totalFeeLabel.Text = totalFee.ToString("c");

            //Send focus to the Clear Button
            clearButton.Focus();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Asign the service price values to labels on form (using currency form)
            fleaRemovalPriceLabel.Text = FLEA_REMOVAL_PRICE.ToString("c");
            nailClippingPriceLabel.Text = NAIL_CLIPPING_PRICE.ToString("c");
            shampooPriceLabel.Text = SHAMPOO_PRICE.ToString("c");
            furTrimmingPriceLabel.Text = FUR_TRIMMING_PRICE.ToString("c");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void totalFeeLabel_Click(object sender, EventArgs e)
        {

        }

        // Handle Clear button's click event 
        // Clear data entry controls and reset form to start-up appearance
        private void clearButton_Click(object sender, EventArgs e)
        {
            ownerNameTextBox.Text = "";
            ownerPhoneMaskedTextBox.Text = "";
            petNameTextBox.Text = "";
            petDOBMaskedTextBox.Text = "";
            catRadioButton.Checked = true;
            fleaRemovalCheckBox.Checked = false;
            nailClippingCheckBox.Checked = false;
            shampooCheckBox.Checked = false;
            furTrimmingCheckBox.Checked = false;
            totalFeeLabel.Text = "";

            // send focus to firs data entry control on the form
            ownerNameTextBox.Focus();

        

        }

        // Handle Quit button's click event 
        // Click the form, ending the program
        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
