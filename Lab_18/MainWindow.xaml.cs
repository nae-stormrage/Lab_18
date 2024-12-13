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

namespace Lab_18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double X = Convert.ToDouble(XTB.Text);
                double Y = Convert.ToDouble(YTB.Text);
                int N = Convert.ToInt32(NTB.Text);
                int K = Convert.ToInt32(KTB.Text);
                double Summa = 0;

                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= K; j++)
                    {
                        Summa += (Math.Cos(Math.Pow(Y, i)) + j * X) / (i * j);
                    }
                }

                ResultTB.Text = Summa.ToString();
            }
            catch 
            {
                ResultTB.Text = "Ошибка! Проблема в цифрах! Решите пж пж!";
            }
        }
    }
}
