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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            Close();
        }

        private void HamburgerBtn_CheckedChanged(object sender, EventArgs e)
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

        private void PizzaBtn_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            DisplayAddOns(pizzaBtn, "Pepperoni", "Sausage", "Olives");
        }

        private void SaladBtn_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            DisplayAddOns(saladBtn, "Crutons", "Bacon Bits", "Bread Sticks");
        }

        private void ClearCheckBoxes()
        {
            firstAddon.Checked = false;
            secondAddon.Checked = false;
            thirdAddon.Checked = false;
        }

        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            double hambPrice = 6.95;
            double pizzaPrice = 5.95;
            double saladPrice = 4.95;


            double addOnPriceHamburger = 0.75;
            double addOnPricePizza = 0.50;
            double addOnPriceSalad = 0.25;

            if (hamburgerBtn.Checked)
            {
                CalculateOrder(hambPrice, addOnPriceHamburger);
            }
            if (pizzaBtn.Checked)
            {
                CalculateOrder(pizzaPrice, addOnPricePizza);
            }
            if (saladBtn.Checked)
            {
                CalculateOrder(saladPrice, addOnPriceSalad);
            }
        }

        private void CalculateOrder(double price, double extraItem)
        {
            double total = 0;
            
            if (firstAddon.Checked)
            {
                total += extraItem;
            }
            if (secondAddon.Checked)
            {
                total += extraItem;
            }
            if (thirdAddon.Checked)
            {
                total += extraItem;
            }

            double subTotal = Math.Round((total + price), 3);
            subtotalTxt.Text = "$" + subTotal.ToString();

            double tax = Math.Round((subTotal * 0.0775), 2);
            taxTxt.Text = "$" + tax.ToString();

            double totalOrder = Math.Round((subTotal + tax), 2);
            orderTotalTxt.Text = "$" + totalOrder.ToString();
            
        }
    }
}
