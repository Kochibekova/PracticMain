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

namespace Task4
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

        private void count_Click(object sender, RoutedEventArgs e)
        {
            int A = Convert.ToInt32(a.Text);
            int B = Convert.ToInt32(b.Text);
            int sum = 0;
            for (int i = A + 1; i < B; i++)
            {
                sum += i;
            }
            answer.Content = sum;

            for (int i = A + 1; i < B; i++)
            {
                if (i % 2 == 1)
                {
                    answer1.Content += $"{i}: ";
                }
            }
        }

        private void z2_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 10; i <= 20; i++)
            {
                k.Content += $"{Math.Pow(i, 2)}: ";
            }
        }

        private void z3_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(za3.Text);
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            f.Content = sum;
        }

        private void z4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Age = Convert.ToInt32(age.Text);
                if (Age < 5 && Age > 0)
                    n.Content = "Премия составляет 10% от заработной платы.";
                else if (Age >= 5 && Age < 10)
                    n.Content = "Премия составляет 15% от заработной платы.";
                else if (Age >= 10 && Age < 15)
                    n.Content = "Премия составляет 25% от заработной платы.";
                else if (Age >= 15 && Age < 20)
                    n.Content = "Премия составляет 35% от заработной платы.";
                else if (Age >= 20 && Age < 25)
                    n.Content = "Премия составляет 45% от заработной платы.";
                else if (Age >= 25)
                    n.Content = "Премия составляет 50% от заработной платы.";
                else if (Age < 0)
                    n.Content = "Выслуга лет не может быть отрицательной.";
            }
            catch
            {
                n.Content = "Error";
            }
        }

        private void z5_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(fuu.Text);
            int i = 1;
            int sum = 1;
        LB1: if (i <= n)
            {
                sum *= i;
                i++;
                goto LB1;
            }
            else
                r.Content = $"Факториал числа {n} = {sum}.";
        }
    }
}
