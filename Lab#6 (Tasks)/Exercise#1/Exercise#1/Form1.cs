using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = GetFirstNumber();
            double num2 = GetSecondNumber();
            double result = Add(num1, num2);
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = GetFirstNumber();
            double num2 = GetSecondNumber();
            double result = Subtract(num1, num2);
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = GetFirstNumber();
            double num2 = GetSecondNumber();
            double result = Multiply(num1, num2);
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = GetFirstNumber();
            double num2 = GetSecondNumber();
            if (num2 == 0)
            {
                MessageBox.Show("Cannot divide by zero.");
                textBox3.Text = "";
            }
            else
            {
                double result = Divide(num1, num2);
                textBox3.Text = result.ToString();
            }
        }

        private double GetFirstNumber()
        {
            return double.TryParse(textBox1.Text, out double num) ? num : 0;
        }

        private double GetSecondNumber()
        {
            return double.TryParse(textBox2.Text, out double num) ? num : 0;
        }

        private double Add(double a, double b)
        {
            return a + b;
        }

        private double Subtract(double a, double b)
        {
            return a - b;
        }

        private double Multiply(double a, double b)
        {
            return a * b;
        }

        private double Divide(double a, double b)
        {
            return a / b;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
