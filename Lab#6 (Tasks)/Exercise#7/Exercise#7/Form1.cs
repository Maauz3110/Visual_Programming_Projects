using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerClock.Start();

            UpdateDateTime();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        
        private void UpdateDateTime()
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy"); 
            lblTime.Text = DateTime.Now.ToString("h:mm:ss tt"); 
        }

    }
}
