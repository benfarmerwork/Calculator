using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(Object sender, EventArgs e)
        {
          
            var button = sender as Button;
            txtDisplay.Text = txtDisplay.Text + button.Text;
        }

       

        private void Buttonclr_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button11.Text;
        }

        double total1 = 0;
        double total2 = 0;
        private void Buttonpls_Click(object sender, EventArgs e)
        {
            total1 +=double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

        }

        private void Buttoneql_Click(object sender, EventArgs e)
        {
            total2 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Text = total2.ToString();
            total1 = 0;

        }
        bool plusButton = false;
        bool minusButton = false;
        private void btnMinus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButton = false;
            minusButton = true;


        }
    }
}
