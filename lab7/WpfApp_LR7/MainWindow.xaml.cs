using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_LR7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Lr_7";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double Z=0;
            try
            {
                double n = Convert.ToDouble(N.Text);
                double k = Convert.ToDouble(K.Text);
                double x = Convert.ToDouble(X.Text);
                double y = Convert.ToDouble(Y.Text);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < k; j++)
                    {
                        Z = (Math.Abs(Math.Pow(x, i)) + Math.Cos(y) * Math.Pow(y, j)) / ((i + 1) * j);
                    }
                }
                this.Title = $" Ответ = {Z}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
