using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            clearCheckBoxes();
            Close();
        }

        private void hamburgerBtn_CheckedChanged(object sender, EventArgs e)
        {
            
            DisplayAddOns(hamburgerBtn, "Lettuce, and Tomato", "Salt and Pepper",
                "Chips");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rBtn"></param>
        /// <param name="chkOne"></param>
        /// <param name="chkTwo"></param>
        /// <param name="chkThree"></param>
        private void DisplayAddOns(RadioButton rBtn, string chkOne, string chkTwo, string chkThree)
        {
            if (rBtn.Checked)
            {
                firstAddon.Text = chkOne;
                secondAddon.Text = chkTwo;
                thirdAddon.Text = chkThree;

            }
        }

        private void pizzaBtn_CheckedChanged(object sender, EventArgs e)
        {
            clearCheckBoxes();
            DisplayAddOns(pizzaBtn, "Pepperoni", "Sausage", "Olives");
        }

        private void saladBtn_CheckedChanged(object sender, EventArgs e)
        {
            clearCheckBoxes();
            DisplayAddOns(saladBtn, "Crutons", "Bacon Bits", "Bread Sticks");
        }

        private void clearCheckBoxes()
        {
            firstAddon.Checked = false;
            secondAddon.Checked = false;
            thirdAddon.Checked = false;
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            double r1Price = 6.95;
            double r2Price = 5.95;
            double r3Price = 4.95;


            double addOnPriceHamburger = .75;
            double addOnPricePizza = .50;
            double addOnPriceSalad = .25;

            if (hamburgerBtn.Checked)
            {
                CalculateOrder(r1Price, addOnPriceHamburger);
            }
            if (pizzaBtn.Checked)
            {
                CalculateOrder(r2Price, addOnPricePizza);
            }
            if (saladBtn.Checked)
            {
                CalculateOrder(r3Price, addOnPriceSalad);
            }
        }

        private void CalculateOrder(double price, double addOn)
        {
            double total = 0;
            
            if (firstAddon.Checked)
            {
                total += addOn;
            }
            if (secondAddon.Checked)
            {
                total += addOn;
            }
            if (thirdAddon.Checked)
            {
                total += addOn;
            }

            double subTotal = total + price;
            double tax = Math.Round((total * 0.065), 2);

            subtotalTxt.Text = subTotal.ToString();
            orderTotalTxt.Text = total.ToString();
            taxTxt.Text = tax.ToString();


        }
    }
}
