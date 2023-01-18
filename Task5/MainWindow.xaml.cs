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

namespace Task5
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

        public double Add()
        {
            double x = Convert.ToDouble(n1.Text);
            double y = Convert.ToDouble(n2.Text);
            return x + y;
        }

        public double Sub()
        {
            double x = Convert.ToDouble(n1.Text);
            double y = Convert.ToDouble(n2.Text);
            return x - y;
        }

        public double Mul()
        {
            double x = Convert.ToDouble(n1.Text);
            double y = Convert.ToDouble(n2.Text);
            return x * y;
        }

        public string Div()
        {
            double x = Convert.ToDouble(n1.Text);
            double y = Convert.ToDouble(n2.Text);
            if (y != 0)
                return $"{x / y}";
            else
                return "На ноль делить нельзя";
        }

        private void z1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Method = Convert.ToString(no.Text);
                switch (Method)
                {
                    case "Div":
                        s.Content = Div();
                        break;
                    case "Sub":
                        s.Content = Sub();
                        break;
                    case "Mul":
                        s.Content = Mul();
                        break;
                    case "Add":
                        s.Content = Add();
                        break;
                }
            }
            catch
            {
                s.Content = "Error";
            }
        }

        private void z2_Click(object sender, RoutedEventArgs e)
        {
            double Money = Convert.ToDouble(m.Text);
            double Conversion = Convert.ToDouble(m1.Text);
            a.Content = Money * Conversion;
        }

        private void z3_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(kol.Text);
            if (x != 0)
                pol.Content = "Число положительное,";
            else
                pol.Content = "Число отрицательное,";

            bool prost = true;
            int n = Convert.ToInt32(kol.Text);
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                pol.Content += " число простое.";
            }
            else
            {
                pol.Content += " число не простое.";
            }
        }

        int x = 0;
        int i = 0;
        private void z4_Click(object sender, RoutedEventArgs e)
        {
            int y = Convert.ToInt32(hol.Text);
            x += y;
            if (i <= 7)
            {
                if (x < 1000)
                {
                    fol.Content = $"Сумма задолженности {1000 - x}";
                    i++;
                }
                else if (x == 1000)
                {
                    i++;
                    fol.Content = "Долг погашен";
                }
                else if (x > 1000)
                {
                    i++;
                    fol.Content = $"Долг погашен, переплата {x - 1000}";
                }
            }
            else
                fol.Content = "Вы не успели погасить долг";
        }

        private void z5_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(tol.Text);
            int i = 1;
            int sum = 1;
        LB1: if (i <= n)
            {
                sum *= i;
                i++;
                goto LB1;
            }
            else
                sol.Content = sum;
        }
    }
}