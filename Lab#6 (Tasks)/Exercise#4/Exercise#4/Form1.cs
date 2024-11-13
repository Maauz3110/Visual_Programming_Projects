using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4
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
                
                double fahrenheit = double.Parse(txtFahrenheit.Text);

                
                double celsius = (fahrenheit - 32) * 5 / 9;

               
                txtCelsius.Text = celsius.ToString("F2"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for Fahrenheit.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
