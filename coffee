using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace practice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double item1 = 120.00;
        double item2 = 110.00;
        double item3 = 125.00;
        double item4 = 150.00;
        double item5 = 90.00;
        double item6 = 135.00;
        double item7 = 155.00;
        double item8 = 162.00;

        double points = 0;
        double total1 ,total2,total3, total4, total5, total6, total7, total8 = 0;
        private double getSum()
        {
            return total1 + total2 + total3 + total4 + total5 + total6 + total7 + total8;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (chkmember.Checked)
            {
                if (radioForhere.Checked)
                {
                   double discount1 = getSum() - 50;
                    lbltotal.Text = discount1.ToString();

                   points = discount1*00.3;
                    lblpoints.Text = points.ToString();

                }
                if (radioTogo.Checked)
                {
                    double discount2 = getSum() - 5 + 10;
                    lbltotal.Text = discount2.ToString();

                   points = discount2*00.3;
                   lblpoints.Text = points.ToString();
                }

            }
           if (!chkmember.Checked)
            {
               lbltotal.Text = getSum().ToString();
            }
          

            else
            {
                radioForhere.Checked = false;
                radioTogo.Checked = false;
                chkmember.Checked = false;

            }

        }

        private void chkCreamy_ValueChanged(object sender, EventArgs e, NumericUpDown trueSizeScalingType)
        {

            if (!chkCreamy.Checked)
            {
                num1.Value = 0;
            }

        }

        private void chksalted_ValueChanged(object sender, EventArgs e)
        {

            if (!chksalted.Checked)
            {
                num2.Value = 0;
            }
        }

        private void chkvanilla_ValueChanged(object sender, EventArgs e)
        {

            if (!chkvanilla.Checked)
            {
                num3.Value = 0;
            }
        }

        private void chkburnt_ValueChanged(object sender, EventArgs e)
        {

            if (!chkburnt.Checked)
            {
                num4.Value = 0;
            }

        }

        private void chkCoffee_ValueChanged(object sender, EventArgs e)
        {

            if (!chkCoffee.Checked)
            {
                num5.Value = 0;
            }
        }

        private void chkIcecreamed_ValueChanged(object sender, EventArgs e)
        {

            if (!chkIcecreamed.Checked)
            {
                num6.Value = 0;
            }
        }

        private void chkgreen_ValueChanged(object sender, EventArgs e)
        {

            if (!chkgreen.Checked)
            {
                num7.Value = 0;
            }
        }

        private void chkjava_ValueChanged(object sender, EventArgs e)
        {
            if (!chkjava.Checked)
            {
                num8.Value = 0;
            }
        }

        private void chkmember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void num1_ValueChanged(object sender, EventArgs e)
        {
            if (chkCreamy.Checked)
            {
                decimal quantity = num1.Value;
                double price = item1 * (int)quantity;
                total1 = price;

            }
            else
            {
                num1.Value = 0;

            }
        }

        private void num2_ValueChanged(object sender, EventArgs e)
        {
            if (chksalted.Checked)
            {  
                decimal quantity = num2.Value;
                double price = item2 * (int)quantity;
                total2 = price;

            }
            else
            {
                num2.Value = 0;

            }
        }


        private void chkCreamy_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCreamy.Checked)
            {
                num1.Value = 0;
            }
        }

        private void chksalted_CheckedChanged(object sender, EventArgs e)
        {

            if (!chksalted.Checked)

            {
                num2.Value = 0;
            }
        }


        private void num3_ValueChanged(object sender, EventArgs e)
        {
            if (chkvanilla.Checked)
            {
                decimal quantity = num3.Value;
                double price = item3 * (int)quantity;
                total3 = price;

            }
            else
            {
                num3.Value = 0;
            }
        }

        private void num4_ValueChanged(object sender, EventArgs e)
        {
            if (chkburnt.Checked)
            {
                decimal quantity = num4.Value;
                double price = item4 * (int)quantity;
                total4 = price;

            }
            else
            {
                num4.Value = 0;
            }
        }

        private void num5_ValueChanged(object sender, EventArgs e)
        {
            {
                if (chkCoffee.Checked)
                {
                    decimal quantity = num5.Value;
                    double price = item5 * (int)quantity;
                    total5 = price;

                }
                else
                {
                    num5.Value = 0;
                }
            }
        }

        private void num6_ValueChanged(object sender, EventArgs e)
        {
            {
                if (chkIcecreamed.Checked)
                {
                    decimal quantity = num6.Value;
                    double price = item6 * (int)quantity;
                    total6 = price;

                }
                else
                {
                    num6.Value = 0;
                }
            }
        }

        private void num7_ValueChanged(object sender, EventArgs e)
        {
            {
                if (chkgreen.Checked)
                {
                    decimal quantity = num7.Value;
                    double price = item7* (int)quantity;
                    total7 = price;

                }
                else
                {
                    num7.Value = 0;
                }
            }
        }

        private void num8_ValueChanged(object sender, EventArgs e)
        {
            
                {
                    if (chkjava.Checked)

                    {
                    
                    decimal quantity = num8.Value;
                    double price = item8 * (int)quantity;
                    total8 = price;

                    }
                    else
                    {
                
                    num8.Value = 0;
                    }
                }
        }

        private void radioTogo_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

