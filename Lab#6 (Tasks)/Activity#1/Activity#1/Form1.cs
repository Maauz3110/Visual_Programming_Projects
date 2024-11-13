using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Focus();
            comboBox1.Items.Add("Day");
            comboBox1.Items.Add("Month");
            comboBox1.Items.Add("Year");
            comboBox1.SelectedIndex = 0;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                label3.Text = $"WELCOME {textBox1.Text}";
                label3.Visible = true; 
            }
            else
            {
                label3.Text = "PLEASE ENTER YOUR NAME";
                label3.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedIndex == 0) 
            {
                for (int i = 1; i <= 30; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                for (int i = 1; i <= 12; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            else // Year
            {
                int currentYear = DateTime.Now.Year;
                for (int i = currentYear - 4; i <= currentYear; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }

            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0; 
            }
        }
    }
}
