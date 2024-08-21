using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rng = new Random();
        int five =0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";

            for (int i = 0; i < 5; i++) 
            { 
             five = rng.Next(1,7);

                textBox1.Text = textBox1.Text + five.ToString() + " ";

            }
            
        }
    }
}
