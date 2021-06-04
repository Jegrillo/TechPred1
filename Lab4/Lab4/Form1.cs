using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab4
{
    public partial class Form1 : Form
    {
        int N;
        Double P;
        string line;
        public Form1()
        {
            InitializeComponent();
            Answer.ReadOnly = true;
            Text = "Тестирование диалоговых окон";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.Color = colorDialog2.Color;
            dlg.ShowHelp = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dlg.Color;
            }
        }

        private void Text_change_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Answer.Font = dlg.Font;
                Elements.Font = dlg.Font;
            }
        }

        private void File_change_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = "txt files (*.txt)|*.txt|" +
                " Мои файлы (Расширение не придумал)|*.xxx|" +
                "Сборки (*.exe)|*.exe";
            dlg.FilterIndex = 3;
            dlg.Title = "Выбор моего файла";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string a = dlg.FileName;
                StreamReader f_in = new StreamReader(a);
                line = f_in.ReadLine();
                N = Convert.ToInt32(line);
                Elements.Text = N.ToString();

            }
        }

       



        private void Solution_Click(object sender, EventArgs e)
        {
            int T = 45;
            int A = 78;
            P = 0;
            int m = -1;
            int k = 0;

            for (int i = 0; i < N; i++)
            {
                m += 2;
                k += 2;
                if (i%2== 0)
                {
                    P -= (Math.Pow(T,m) * Math.Sin(Math.Pow(A,i+1)))/(m*k);
                }
                else
                {
                    P += Math.Pow(T, m) * Math.Cos(Math.Pow(A, i + 1))/ (m * k);
                }
            }
            Answer.Text = P.ToString();
        }

        private void Elements_TextChanged(object sender, EventArgs e)
        {
            try
            {
                N = Convert.ToInt32(Elements.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
