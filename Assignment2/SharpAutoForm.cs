using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Program Name: Sharp Auto Form     Date Last Modified: February 12th
//Name: Caitlin Foster              student#: 200311158
//This program will allow a user to calcuylate a customized a car order

namespace Assignment2
{
    public partial class SharpAutoForm : Form
    {
        //Private instance variables==============================

        private double _autoFinish = 1000;
        private double _additionalItems= 0;
        private double _basePrice= 0;
        private double _tradeInPrice= 0;
        private double _total = 0;
        private double _subtotal = 0;
        private double _amountDue = 0;
        private double _tax =0;
  
        //CONSTRUCTOR=============================================
        public SharpAutoForm()
        {
            InitializeComponent();
        }

        //PUBLIC PROPERTIES======================================
        public bool Checked { get; set; }

        //PRIVATE METHODS========================================

        //EVENT HANDLERS++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This method gives the user a brief description about the program when the toolstrip item about is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program allows a user to calculate the amount due on their customizable vehicle");
        }

        /// <summary>
        /// this method sees which radiobutton has been selected and updates the additional cost appropriatly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _sharpAutoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton sharpAutoRadioButton = sender as RadioButton;
            
            if(CustomRadioButton.Checked)
            {
                _autoFinish = 5000;
            }

            else if(PearlizedRadioButton.Checked)
            {
                _autoFinish = 2500;
            }

            else if(StandardRadioButton.Checked)
            {
                _autoFinish = 1000;
            }

            //update additional options textbox with new additional cost
            AdditionalTextBox.Text = Convert.ToString(_autoFinish + _additionalItems);
        }


        /// <summary>
        /// this method does all the calculations and displays them when the calculate button is pushed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //validate the users input for base price
            if (double.TryParse(BasePriceTextBox.Text, out _basePrice))
            {
                //if yes see if its 1000 or less
                if (_basePrice < 1000)
                {
                    MessageBox.Show("Please enter a number over a $1000");
                }

            }

            else
            {
                //if no ask user for a number and clear the textbox
                MessageBox.Show("Please enter a number");
                BasePriceTextBox.Text = "";
            }

            //see if check boxes checked and add additional costs where applicable
            if (NavigationCheckBox.Checked)
            {
                _additionalItems += 800;
            }

            if (InteriorCheckBox.Checked)
            {
                _additionalItems += 2500;
            }

            if (StereoCheckBox.Checked)
            {
                _additionalItems = 500;
            }

            //validate users input for trad in allowance
            if (double.TryParse(TradeTextBox.Text, out _tradeInPrice))
            {
                //if yes see if its less than 0
                if (_tradeInPrice > 0)
                {
                    MessageBox.Show("Please enter a number of 0 or greater");
                }

            }

            else
            {
                //if no ask user for a number
                MessageBox.Show("Please enter a number");
                TradeTextBox.Text = "";
            }


            AdditionalTextBox.Text = Convert.ToString(_autoFinish + _additionalItems);

            //calculate subtotal and display it
            _subtotal = (_basePrice + _autoFinish + _additionalItems) ;
            SubTotalTextBox.Text = Convert.ToString(_subtotal);

            //calculate tax and display it
            _tax = (_subtotal * 0.13);
            TaxTextBox.Text = Convert.ToString(_tax);

            //calculate total and display it
            _total = (_subtotal + _tax);
            TotalTextBox.Text = Convert.ToString(_total);

            //calculate amount due and display it
            _amountDue = (_total - _tradeInPrice);
            AmountDueTextBox.Text = Convert.ToString(_amountDue);

        }

        /// <summary>
        /// this method clears all textboxes on the form and resets all values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear all text boxes
            BasePriceTextBox.Text = "";
            AdditionalTextBox.Text = "1000";
            SubTotalTextBox.Text = "";
            TaxTextBox.Text = "";
            TotalTextBox.Text = "";
            TradeTextBox.Text = "0";
            AmountDueTextBox.Text = "";

            //reset all variables
            _additionalItems = 0;
            _autoFinish = 0;
            _basePrice = 0;
            _tradeInPrice = 0;
            _total = 0;
            _subtotal = 0;
            _amountDue = 0;
            _tax = 0;
            
            //reset all checkboxes and radio buttons

            NavigationCheckBox.Checked = false;
            InteriorCheckBox.Checked = false;
            StereoCheckBox.Checked = false;
            StandardRadioButton.Checked = true;
        }

        /// <summary>
        /// thos methods closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
