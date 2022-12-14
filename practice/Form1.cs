using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                double coef = 1.05;
               double val = Math.Pow(double.Parse(textBox1.Text), coef);
                double sum1 = val * 2.4;
                double coef2 = 0.38;
                double val2 = Math.Pow(sum1, coef2);
                double sum2 = val2 * 2.5;
                textBox2.Text = Math.Round(sum1,2).ToString();
                textBox3.Text = Math.Round(sum2,2).ToString();
                textBox4.Text = Math.Round(double.Parse(textBox1.Text)/sum1, 2).ToString();
                textBox5.Text = Math.Round(sum1/sum2,2).ToString(); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Calculate";
            button2.Text = "2zad";
            label1.Text = "ХРПК";
            label2.Text = "ЧМ";
            label3.Text = "B";
            label4.Text = "Производителност";
            label5.Text = "Eкип";
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
