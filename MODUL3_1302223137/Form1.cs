using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODUL3_1302223137
{
    public partial class Form1 : Form
    {
        static string output = " ";
        static int jumlah = 0;
        static int jumlah2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = (textBox1.Text + button1.Text);
            output = output + button1.Text;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (textBox1.Text + button2.Text);
            output = output + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (textBox1.Text + button3.Text);
            output = output + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = (textBox1.Text + button4.Text);
            output = output + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = (textBox1.Text + button5.Text);
            output = output + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = (textBox1.Text + button6.Text);
            output = output + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = (textBox1.Text + button7.Text);
            output = output + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = (textBox1.Text + button8.Text);
            output = output + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = (textBox1.Text + button9.Text);
            output = output + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = (textBox1.Text + button10.Text);
            jumlah2 = int.Parse(output);
            jumlah = jumlah + jumlah2;
            jumlah2 = 0;
            output = " ";
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = (textBox1.Text + button11.Text);
            output = output + button10.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            jumlah2 = int.Parse(output);
            jumlah = jumlah + jumlah2;
            string exit = Convert.ToString(jumlah);
            textBox1.Text = exit;
            jumlah2 = 0;
            output = "0";

        }
    }
}
