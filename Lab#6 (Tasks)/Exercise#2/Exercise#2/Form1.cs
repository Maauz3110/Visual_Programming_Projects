using System;
using System.Windows.Forms;

namespace Exercise_2
{
    public partial class Form1 : Form
    {
        private double resultValue = 0;
        private string operationPerformed = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || isOperationPerformed)
                txtDisplay.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }

        
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            
            if (resultValue != 0 && !isOperationPerformed)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
                txtDisplay.Text = resultValue.ToString() + " " + operationPerformed;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(txtDisplay.Text);
                txtDisplay.Text = resultValue.ToString() + " " + operationPerformed;
            }

            isOperationPerformed = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtDisplay.Text = (resultValue + double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultValue - double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (resultValue * double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(txtDisplay.Text) != 0)
                    {
                        txtDisplay.Text = (resultValue / double.Parse(txtDisplay.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        txtDisplay.Text = "0";
                    }
                    break;
            }
            resultValue = double.Parse(txtDisplay.Text);
            operationPerformed = "";
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
            operationPerformed = "";
            isOperationPerformed = false;
        }

        
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }
    }
}
