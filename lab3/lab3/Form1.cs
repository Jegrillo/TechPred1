using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        int a, b, c_a, c_b,posX,posY;
        double x,c_x,c_y,c_z, y, z;

        DateTimeFormat dtFormat = DateTimeFormat.ShowDate;
        ToolStripMenuItem currentCheckedItem;
        public Form1()
        {
            InitializeComponent();
            Text = "Пример строки состояния";
            CenterToScreen();
            BackColor = Color.CadetBlue;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox2.SelectedIndex = 0;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackColor = ColorChange();
        }
        public Color ColorChange()
        {
            switch (ComboBox2.Text)
            {
                case "Белый":; BackColor = Color.White; break;
                case "Красный":; BackColor = Color.Red; break;
                case "Черный":; BackColor = Color.Black; break;
                case "Синий":; BackColor = Color.Blue; break;
                case "Желтый":; BackColor = Color.Yellow; break;

                default: BackColor = SystemColors.Control; break;

            }
            return BackColor;
        }

        private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BackColor = Color.FromArgb(
                    Convert.ToInt32(toolStripTextBox4.Text),
                    Convert.ToInt32(toolStripTextBox5.Text),
                    Convert.ToInt32(toolStripTextBox6.Text));
            }
            catch
            {
                MessageBox.Show("Необходимо ввести целое число от 0 до 255");
            }
        }

        private void toolStripTextBox5_TextChanged(object sender, EventArgs e)
        {
            toolStripTextBox4_TextChanged(sender,e);
        }

        private void toolStripTextBox6_TextChanged(object sender, EventArgs e)
        {
            toolStripTextBox4_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
             BackColor = ColorChange_Context();
        }

        public Color ColorChange_Context()
        {
            switch (toolStripComboBox1.Text)
            {
                case "Белый":; BackColor = Color.White; break;
                case "Красный":; BackColor = Color.Red; break;
                case "Черный":; BackColor = Color.Black; break;
                case "Синий":; BackColor = Color.Blue; break;
                case "Желтый":; BackColor = Color.Yellow; break;

                default: BackColor = SystemColors.Control; break;

                    
            }
            return BackColor;
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BackColor = Color.FromArgb(
                    Convert.ToInt32(toolStripTextBox1.Text),
                    Convert.ToInt32(toolStripTextBox2.Text),
                    Convert.ToInt32(toolStripTextBox3.Text));
            }
            catch
            {
                MessageBox.Show("Необходимо ввести целое число от 0 до 255");
            }
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            toolStripTextBox1_TextChanged(sender, e);
        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            toolStripTextBox1_TextChanged(sender, e);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripMenuItem3_Click(sender, e);
        }

        public enum DateTimeFormat
        {
            ShowTime,
            ShowDate
        }

        private void timerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            string info = "";
            if (dtFormat == DateTimeFormat.ShowTime)
                info = DateTime.Now.ToLongTimeString();
            else
                info = DateTime.Now.ToLongDateString();
            toolStripStatusLabelClock.Text = info;
        }

        private void toolStripMenuItemDate_Click(object sender, EventArgs e)
        {
            //установка даты
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowDate;
            currentCheckedItem = toolStripMenuItemDate;
            currentCheckedItem.Checked = true;
        }

        private void toolStripMenuItemTime_Click(object sender, EventArgs e)
        {
            //установка времени
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowTime;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }


        public void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelState.Text = string.Format("Текущие координаты {0}, {1}", e.X, e.Y);

            posX = e.X;
            posY = e.Y;
            if (sqt_xy.Checked)
            { 
                vivod_xy.Text = string.Format("z =  {0}", Math.Sin(e.X));
                uravnenie_xy.Checked = true;
                sqt_xy.Checked = false;
            }
            else
            {
                vivod_xy.Text = string.Format("z = {0}, а f = {1}",Math.Abs(Math.Pow(e.X,3) - Math.Pow(e.Y, 3)), Math.Pow(e.X,2)/Math.Pow(e.Y, 2));
                uravnenie_xy.Checked = true;
            }
            
        } 

        private void const_a_TextChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(const_a.Text);
        }

        private void const_b_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(const_b.Text);
        }

        private void perem_x_TextChanged(object sender, EventArgs e)
        {
            x = Convert.ToDouble(perem_x.Text);
        }
        private void Context_reshenie_Click(object sender, EventArgs e)
        {

            Text = Solution_Context();
        }

        public string Solution_Context()
        {
            double c_Answer = ((c_a*c_x)/c_b) + ((c_b*c_y)/c_x) + Math.Sin(c_z);
            return $"{c_Answer}";
        }

        private void Context_perem_x_TextChanged(object sender, EventArgs e)
        {
            c_x = Convert.ToDouble(Context_perem_x.Text);
        }
        public void sqt_xy_Click(object sender, EventArgs e)
        {
           /* vivod_xy.Text = string.Format("Координаты = {0}, {1}", posX*posX ,  posY*posY);*/
        }

        private void Context_const_a_TextChanged(object sender, EventArgs e)
        {
            c_a = Convert.ToInt32(Context_const_a.Text);
        }

        private void Context_const_b_TextChanged(object sender, EventArgs e)
        {
            c_b = Convert.ToInt32(Context_const_b.Text);
        }

        private void Context_perem_y_TextChanged(object sender, EventArgs e)
        {
            c_y = Convert.ToDouble(Context_perem_y.Text);
        }

        private void Context_perem_z_TextChanged(object sender, EventArgs e)
        {
            c_z = Convert.ToDouble(Context_perem_z.Text);
        }

        private void perem_y_TextChanged(object sender, EventArgs e)
        {
            y = Convert.ToDouble(perem_y.Text);
        }
        private void perem_z_TextChanged(object sender, EventArgs e)
        {
            z = Convert.ToDouble(perem_z.Text);
        }
        private void reshenie_Click(object sender, EventArgs e)
        {

            Text = Solution();
        }
        public string Solution()
        {
            double Answer = a * (x / y) + b * (y / z) + Math.Sin(z / x);
            return $"{Answer}";
        }
    }
}
