using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Formative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            string hockey = "Wayne Gretzky ";
            int great;

            great = 99;
            label1.Text = hockey + " is the number " + great;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            double Area;
            int radius = 15;
            double pi = 3.14;

            Area = pi * radius * radius;
            label2.Text = "The area of a circle with a radius of 15 is " + Area + "m";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;

            double area;
           const double price = 19.95;
            double COST;

            area = 8.5 * 6;
            COST = area * price;
            label3.Text = "The cost for a " + area + " meter carpet at " + price + "$ per meter is " + COST + "$";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

           const double shirt = 12.49;
            double bill = 20;
            const double TAX = 1.13;
            double change;
            double total;

            total = shirt * TAX;
            change = bill - total;

            label4.Text = "The price of the shirt was " + shirt + "$ with a tax of 13%, making the total " + total + "$ and his change " + change + "$";
            
            


            
        }
    }
}
