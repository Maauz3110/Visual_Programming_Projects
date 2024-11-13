using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lvSquares.Items.Clear();

            
            for (int i = 1; i <= 10; i++)
            {
                int square = CalculateSquare(i);

                
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(square.ToString());

                
                lvSquares.Items.Add(item);
            }
        }
        private int CalculateSquare(int number)
        {
            return number * number;
        }

    }
}
