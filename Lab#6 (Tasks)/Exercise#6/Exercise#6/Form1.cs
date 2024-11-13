using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Exercise_6
{
    public partial class Form1 : Form
    {
        private int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            timeLeft = (int)numSetTime.Value;
            lblCountdown.Text = timeLeft + " Seconds.";

            
            timerCountdown.Start();
        }

        
        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
               
                timeLeft--;
                lblCountdown.Text = timeLeft + " Seconds.";
            }
            else
            {
                
                timerCountdown.Stop();
                MessageBox.Show("Time Over!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                lblCountdown.Text = "0 Seconds.";
            }
        }
            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
