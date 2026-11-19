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
    public partial class Form2 : Form
    {
        private double danielle;
        private double edward;
        private double fatima;

        public Form2(double d, double e, double f)
        {
            InitializeComponent();

            label2.Text = "Danielle: ₱" + d.ToString("F2");
            label3.Text = "Edward: ₱" + e.ToString("F2");
            label4.Text = "Fatima: ₱" + f.ToString("F2");
            label5.Text = "Grand Total: ₱" + (d + e + f).ToString("F2");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}