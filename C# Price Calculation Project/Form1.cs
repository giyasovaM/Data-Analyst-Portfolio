using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_1
{
    public partial class Form1 : Form
    {
        // Declaring class-level constants for tax rates and commissions
        private const decimal STATE_LEVEL_TAX_RATE = 0.06m;
        private const decimal HILLSBOROUGH_SALES_TAX_RATE = 0.01m;
        private const decimal PASCO_SALES_TAX_RATE = 0m;
        private const decimal POLK_SALES_TAX_RATE = 0.005m;
        private const decimal PRESIDENTIAL_COMMISSION_RATE = 0.06m;
        private const decimal COMMERCIAL_COMMISSION_RATE = 0.05m;

        //Declaring class-level variables for use in calculations of totals 

        private decimal propertyPrice = 0m;
        private decimal stateSalesTax = 0m;
        private decimal countySalesTax = 0m;
        private decimal commission = 0m;
        private decimal totalPrice = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Displaying current datte in this control
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Save button is disabled untill price is greater than 0 
            saveButton.Enabled = false;


        }

        // Customized method for updating total fields
        private void UpdateTotals()
        {
            // Reading the price of the property entered bu users
            if (decimal.TryParse(propertyPriceTextBox.Text, out propertyPrice))
            {
                // property price is equal to text property of TextBox
                propertyPrice = decimal.Parse(propertyPriceTextBox.Text);

                //Calculating State sales tax amount
                stateSalesTax = propertyPrice * STATE_LEVEL_TAX_RATE;
                if (hillsboroughRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * HILLSBOROUGH_SALES_TAX_RATE;

                }
                else if (pascoRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * PASCO_SALES_TAX_RATE;

                }
                else if (polkRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * POLK_SALES_TAX_RATE;
                }

                // Calculating commission based on propert type
                if( residentialRadioButton.Checked)
                {
                    commission = propertyPrice * PRESIDENTIAL_COMMISSION_RATE;
                }
                else
                {
                    commission = propertyPrice * COMMERCIAL_COMMISSION_RATE;

                }

                totalPrice = propertyPrice + stateSalesTax + countySalesTax + commission;

                // displaying numeric values in currency format 

                stateSalesTaxaLabel.Text = stateSalesTax.ToString("c");
                countySalesTaxLabel.Text = countySalesTax.ToString("c");
                commissionLabel.Text = commission.ToString("c");
                totalPriceLabel.Text = totalPrice.ToString("c");

                // Entered value is greater than 0
                if (propertyPrice > 0)
                {
                    saveButton.Enabled = true; 

                }
                else // if 0 or non-numeric value entered
                {
                    MessageBox.Show("You must enter a numeric value for propert Price" +
                        "\nEnter digits only (no dollar sign) for Propert Price",
                        "Blank Value or Non-Numeric Character Entered",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                propertyPriceTextBox.Focus(); //sending back to property price text box

            }




        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            try // Write Data to extrernal text file
            {
                // declaring streamwriter object for use in writing file
                StreamWriter outputFile;
                outputFile = File.AppendText("Properties.txt");
                // Writing all data to file
                outputFile.WriteLine("Date: " + dateMaskedTextBox.Text);
                outputFile.WriteLine("Property Price: " + propertyPrice.ToString("c"));
                outputFile.WriteLine("State Sales Tax: " + stateSalesTax.ToString("c"));
                outputFile.WriteLine("State Sales Tax: " + stateSalesTax.ToString("c"));
                outputFile.WriteLine("County Sales Tax: " + countySalesTax.ToString("c"));
                outputFile.WriteLine("Commission: " + commission.ToString("c"));
                outputFile.WriteLine("Total Price: " + totalPrice.ToString("c"));
                outputFile.WriteLine(); // a blank line to file 
                outputFile.Close(); // closing output file after writing data

                // Displaying confirmation message 
                MessageBox.Show("Data successfully saved to file", "Confirmation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); 

            }

            catch(Exception ex)
            {
                // Displaying message if error occurs
                MessageBox.Show(ex.Message);

            }
        }

        private void propertyPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            //Disabling Save Button
            saveButton.Enabled = false;

        }

        private void residentialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();// calling method to update calculated total
        }

        private void hillsboroughRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();// calling method to update calculated total
        }

        private void pascoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals(); // calling method to update calculated total
        }

        // Custom method to clear form
        private void ClearForm()
        {
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            residentialRadioButton.Checked = true;
            hillsboroughRadioButton.Checked = true;
            propertyPriceTextBox.Text = "0.00";
            stateSalesTaxaLabel.Text = "$0.00";
            countySalesTaxLabel.Text = "$0.00";
            commissionLabel.Text = "$0.00";
            totalPriceLabel.Text = "$0.00";
            saveButton.Enabled = false; //Disabling save button
            propertyPriceTextBox.Focus();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm(); // Call custom method
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updatePropertyPriceButton_Click(object sender, EventArgs e)
        {
            UpdateTotals();
            saveButton.Focus();
        }

        private void commercialRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
