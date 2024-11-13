using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                int number = int.Parse(txtNumber.Text);

               
                long factorial = CalculateFactorial(number);

               
                txtFactorial.Text = factorial.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number is too large for factorial calculation.", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private long CalculateFactorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Number must be non-negative.");

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
