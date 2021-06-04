using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {   
        double D2, BB, ans;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            ans = Math.Pow(Math.Abs(D2 - e.X), 0.5) * e.X + Math.Abs(Math.Pow(BB, 3)) - Math.Abs(Math.Pow(e.X, 2) + Math.Cos(e.Y));

            if (ans-ans == 0)
            {
                Text = ans.ToString();
                U.ReadOnly = true;
                U.Text = Text.ToString();

            }
            else
                Text = "Error";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { 
   
            D2 = Convert.ToDouble(d2.Text);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                BB = Convert.ToDouble(bb.Text);

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
