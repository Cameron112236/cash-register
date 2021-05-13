using System;
using System.Windows.Forms;
using System.Threading;
using System.Media;
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
        //Cost of purcheses
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


            //Math for custumer total
            subTotal = (vanillaAmount * vanillaCost) + (chocolateAmount * chocolateCost) + (swirlAmount * swirlCost);

            taxAmount = taxRate * subTotal;
   

            total = subTotal + taxAmount;


            Calculated.Text = $"${subTotal} \n \n ${taxAmount.ToString(".##")} \n \n ${total.ToString(".##")}";
        }

        private void change_Click(object sender, EventArgs e)
        {
            //change calculation
            tendered = Convert.ToDouble(value: tenderedAmount.Text);
            changeMade = tendered - total;

            changeMade.ToString(".##");

            changeGiven.Text = $"${changeMade.ToString(".##")}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void recite14_Click(object sender, EventArgs e)
        {

        }

        private void createReceipt_Click(object sender, EventArgs e)
        {
            //recite sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.receiptPrinting);

            // recite text and sound
            recite.Text  = $" Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();

            player.Play();
            recite.Text = $"\n Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();

            player.Play();
            recite.Text = $" Change          ${changeMade.ToString(".##")}\n \n Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();

            player.Play();
            recite.Text = $" Tendered        ${tendered}\n Change          ${changeMade.ToString(".##")}\n \n Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();

            player.Play();
            recite.Text = $"\n Tendered      ${tendered}\n Change          ${changeMade.ToString(".##")}\n \n Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();

            player.Play();
            recite.Text = $" Total           ${total.ToString(".##")}\n \n Tendered        ${tendered}\n Change          ${changeMade.ToString(".##")}\n \n Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();

            player.Play();
            recite.Text = $" Tax             ${taxAmount.ToString(".##")}\n Total           ${total.ToString(".##")}\n \n Tendered        ${tendered}\n Change          ${changeMade.ToString(".##")}\n \n Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();

            player.Play();
            recite.Text = $" Subtotal        ${subTotal}\n Tax             ${taxAmount.ToString(".##")}\n Total           ${total.ToString(".##")}\n \n Tendered        ${tendered}\n Change          ${changeMade.ToString(".##")}\n \n Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();

            player.Play();
            recite.Text = $"\n Subtotal        ${subTotal}\n Tax             ${taxAmount.ToString(".##")}\n Total           ${total.ToString(".##")}\n \n Tendered        ${tendered}\n Change          ${changeMade.ToString(".##")} \n \n Thank you for your purchase!!";
            Thread.Sleep(1000);

            recite.Refresh();
            player.Play();

            recite.Text = $" Vanilla   * {vanillaAmount} @    ${vanillaAmount * vanillaCost}\n \n Subtotal        ${subTotal}\n Tax             ${taxAmount.ToString(".##")}\n Total           ${total.ToString(".##")}\n \n Tendered        ${tendered}\n Change          ${changeMade.ToString(".##")} \n \n Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();
            player.Play();

            recite.Text = $" Chocolate * {chocolateAmount} @ ${chocolateAmount * chocolateCost}\n Vanilla * {vanillaAmount} @   ${vanillaAmount * vanillaCost}\n \n Subtotal        ${subTotal}\n Tax             ${taxAmount.ToString(".##")}\n Total           ${total.ToString(".##")}\n \n Tendered        ${tendered}\n Change          ${changeMade.ToString(".##")} \n \n Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();
            player.Play();

            recite.Text = $" Swirl  * {swirlAmount} @    ${swirlAmount * swirlCost}\n Chocolate * {chocolateAmount} @   ${chocolateAmount * chocolateCost}\n Vanilla * {vanillaAmount} @   ${vanillaAmount * vanillaCost}\n \n Subtotal        ${subTotal}\n Tax             ${taxAmount.ToString(".##")}\n Total           ${total.ToString(".##")}\n \n Tendered        ${tendered}\n Change          ${changeMade.ToString(".##")} \n \n Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();
            player.Play();

            recite.Text = $"\n  Swirl * {swirlAmount} @   ${swirlAmount * swirlCost}\n Chocolate * {chocolateAmount} @   ${chocolateAmount * chocolateCost}\n Vanilla * {vanillaAmount} @   ${vanillaAmount * vanillaCost}\n \n Subtotal        ${subTotal}\n Tax             ${taxAmount.ToString(".##")}\n Total           ${total.ToString(".##")}\n \n Tendered        ${tendered}\n Change          ${changeMade.ToString(".##")} \n \n Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();
            player.Play();

            recite.Text = $"         May 12, 2021\n \n  Swirl * {swirlAmount} @   ${swirlAmount * swirlCost}\n Chocolate * {chocolateAmount} @   ${chocolateAmount * chocolateCost}\n Vanilla * {vanillaAmount} @   ${vanillaAmount * vanillaCost}\n \n Subtotal        ${subTotal}\n Tax             ${taxAmount.ToString(".##")}\n Total           ${total.ToString(".##")}\n \n Tendered        ${tendered}\n Change          ${changeMade.ToString(".##")} \n \n Thank you for your purchase!!";
            Thread.Sleep(1000);
            recite.Refresh();
            player.Play();

            recite.Text = $"         Icecream Shop\n         May 12, 2021\n \n  Swirl * {swirlAmount} @   ${swirlAmount * swirlCost}\n Chocolate * {chocolateAmount} @   ${chocolateAmount * chocolateCost}\n Vanilla * {vanillaAmount} @   ${vanillaAmount * vanillaCost}\n \n Subtotal        ${subTotal}\n Tax             ${taxAmount.ToString(".##")}\n Total           ${total.ToString(".##")}\n \n Tendered        ${tendered}\n Change          ${changeMade.ToString(".##")} \n \n Thank you for your purchase!!";
            player.Play();
            Thread.Sleep(1000);
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // amount each item costs
            double vanillaCost = 1.29;
            double chocolateCost = 1.29;
            double swirlCost = 2.00;

            // Amount of each item purchased
            double vanillaAmount = 0;
            double chocolateAmount = 0;
            double swirlAmount = 0;

            //Cost of purcheses
            double subTotal = 0;
            double taxRate = 0.13;
            double taxAmount = 0;
            double total = 0;

            //amount paid and given to custimer
            double tendered = 0;
            double changeMade = 0;

            // Recite says nothing
            recite.Text = "";

            //Reset where Custumer puts what they want
            vanillaNumber.Text = "0";
            chocolateNumber.Text = "0";
            swirlNumber.Text = "0";
            tenderedAmount.Text = "0";
            changeGiven.Text = "$0";



            Calculated.Text = $"${subTotal} \n \n ${taxAmount} \n \n ${total}";

        }
    }
}
