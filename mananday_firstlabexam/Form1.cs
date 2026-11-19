using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mananday_firstlabexam
{
    public partial class Form1 : Form
    {
        private double total_Danielle = 0;
        private double total_Edward = 0;
        private double total_Fatima = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getSalesPerson_Amount(string initial, double amount)
        {
            initial = initial.ToUpper().Trim();

            if (initial == "D")
            {
                total_Danielle += amount;
            }
            else if (initial == "E")
            {
                total_Edward += amount;
            }
            else if (initial == "F")
            {
                total_Fatima += amount;
            }
            else
            {
                label1.Text = "Invalid initial! Use D, E, or F.";
                return;
            }


            label4.Text =
                "Danielle: ₱" + total_Danielle.ToString("F2") + "\n" +
                "Edward:   ₱" + total_Edward.ToString("F2") + "\n" +
                "Fatima:   ₱" + total_Fatima.ToString("F2") + "\n" +
                "GRAND:    ₱" + (total_Danielle + total_Edward + total_Fatima).ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string displayDanielle = $"Danielle: ₱{total_Danielle:F2}";
            string displayEdward = $"Edward: ₱{total_Edward:F2}";
            string displayFatima = $"Fatima: ₱{total_Fatima:F2}";

            Form2 form2 = new Form2(total_Danielle, total_Edward, total_Fatima);
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double saleAmount) && saleAmount > 0)
            {
                getSalesPerson_Amount(textBox1.Text, saleAmount);
            }
            else
            {
                label1.Text = "Please enter a valid positive number for the sale amount.";
            }
        }
        

    }
}

