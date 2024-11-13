using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_9
{
    public partial class Form1 : Form
    {
        private const int MaxCharacters = 160;
        public Form1()
        {
            InitializeComponent();
            UpdateCharacterCount();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Text changed event triggered");
            UpdateCharacterCount();
        }

        private void UpdateCharacterCount()
        {
            int charactersLeft = MaxCharacters - txtInput.Text.Length;
            lblCharactersLeft.Text = $"Characters Left: {charactersLeft}";
            Console.WriteLine($"Characters Left: {charactersLeft}");
        }

    }
}
