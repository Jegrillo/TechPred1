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
        public Form1()
        {
            InitializeComponent();
        }

        private void check_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Makeit_Click(object sender, EventArgs e)
        {
            int k = 1;
            Double Zoo = 0;
            int n = Convert.ToInt32(N.Text);
            int r = Convert.ToInt32(R.SelectedItem.ToString());
            Double x = Convert.ToDouble(X.Text);
            int b = Convert.ToInt32(B.SelectedItem.ToString());
            Double y = Convert.ToDouble(Y.Text);
            Double a = Convert.ToDouble(A.Text);

            if (equation1.Checked)
            {
                for (int i = 0; i < n; i++)
                {
                    k += 2;
                    if (i == 0)
                    {
                        Zoo += -1;
                    }
                    else if (i%2==0)
                    {
                        Zoo+=Math.Pow(y, i) / k;
                    }
                    else
                    {
                        Zoo += -1 * Math.Pow(x, i) / k;
                    }
                }
            }
            else if (equation2.Checked)
            {
                Zoo = 0;
                for (int i=0; i<n; i++)
                {
                    for (int j = 0; j < r; j++)
                    {
                        Zoo = Zoo + 1.00d * (a * Math.Pow(j, 2) + 2) / (b* Math.Pow(i, j)+3);
                    }
                }
                
            }
            
            Answer.Text = Zoo.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Y_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
