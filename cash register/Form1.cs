using System;
using System.Windows.Forms;

namespace cash_register
{
    public partial class register : Form
    {
        // amount each item costs
        double vanillaCost = 1.29;
        double chocolateCost = 1.29;
        double swirlCost = 2.00;
        // Amount of each item purchased
        double vanillaAmount = 0;
        double chocolateAmount = 0;
        double swirlAmount = 0;
        //
        double subTotal = 0;
        double taxRate =0.13;
        double taxAmount = 0;
        double total = 0;
        double tendered = 0;

        double changeMade = 0;

        public register()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //Grab amount of each item user wants
            vanillaAmount = Convert.ToDouble(value: vanillaNumber.Text);
            chocolateAmount = Convert.ToDouble(value: chocolateNumber.Text);
            swirlAmount = Convert.ToDouble(value: swirlNumber.Text);
            //
            subTotal = (vanillaAmount * vanillaCost) + (chocolateAmount * chocolateCost) + (swirlAmount * swirlCost);

            taxAmount = taxRate * subTotal;

            total = subTotal + taxAmount;

            Calculated.Text = $"${subTotal} \n \n ${taxAmount} \n \n ${total}";
        }

        private void change_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToDouble(value: tenderedAmount.Text);
            changeMade = tendered - total;

            changeGiven.Text = $"${changeMade}";
        }
    }
}
