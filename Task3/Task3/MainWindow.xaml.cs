using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace Task3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 3
    public partial class MainWindow : Window
    {
        //3
        public MainWindow()
        {
            InitializeComponent();
            this.bbb.Items.Add("+");
            this.bbb.Items.Add("-");
            this.bbb.Items.Add("/");
            this.bbb.Items.Add("");
        }
        private void promejutok_Click(object sender, RoutedEventArgs e)
        {
            int chislo = Convert.ToInt32(number.Text);
            if (chislo < 15)
                L.Content = "[0-14]";
            else if (chislo < 36)
                L.Content = "[15-35]";
            else if (chislo < 51)
                L.Content = "[36-50]";
            else if (chislo < 101)
                L.Content = "[50-100]";
        }
            //1
            private void translate_Click(object sender, RoutedEventArgs e)
        {
            string sultry = "знойно";
            string stuffi = "духота";
            string couldy = "пасмурно";
            string foggy = "туманно";
            string cold = "холодно";
            string hot = "жарко";
            string wind = "ветренно";
            string hurri = "ураган";
            string rain = "дождливо";
            string sun = "солнечно";
            if (sun == tb1.Text)
            {
                perevod.Content = "sunny";
            }

            else if (rain == tb1.Text)
            {
                perevod.Content = "rainy";
            }

            else if (hurri == tb1.Text)
            {
                perevod.Content = "hurricane";
            }

            else if (wind == tb1.Text)
            {
                perevod.Content = "windy";
            }

            else if (hot == tb1.Text)
            {
                perevod.Content = "hot";
            }

            else if (cold == tb1.Text)
            {
                perevod.Content = "cold";
            }

            else if (foggy == tb1.Text)
            {
                perevod.Content = "foggy";
            }

            else if (sultry == tb1.Text)
            {
                perevod.Content = "sultry";
            }

            else if (stuffi == tb1.Text)
            {
                perevod.Content = "stuffiness";
            }

            else if (couldy == tb1.Text)
            {
                perevod.Content = "couldy";
            }
            else
            {
                perevod.Content = "Введите другое слово!";
            }
        }




        private void _2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (bbb.SelectedIndex)
                {
                    case 0:
                        double x = Convert.ToDouble(number1.Text);
                        double y = Convert.ToDouble(number2.Text);
                        answer.Content = x + y;

                        break;

                    case 1:
                        x = Convert.ToDouble(number1.Text);
                        y = Convert.ToDouble(number2.Text);
                        answer.Content = x - y;
                        dop.Content = "";
                        break;

                    case 2:
                        x = Convert.ToDouble(number1.Text);
                        y = Convert.ToDouble(number2.Text);
                        if (y == 0)
                        {
                            dop.Content = "На ноль делить нельзя";
                            dop.Foreground = Brushes.Red;
                        }


                        else
                        {
                            answer.Content = x / y;
                            dop.Content = "";
                        }
                        break;

                    case 3:
                        x = Convert.ToDouble(number1.Text);
                        y = Convert.ToDouble(number2.Text);
                        answer.Content = x * y;
                        dop.Content = "";
                        break;
                    case 4:
                        x = Convert.ToDouble(number1.Text);
                        answer.Content = Math.Round(Math.Sin(x));
                        dop.Content = "Число для подсчета вводиться в первое поле";
                        dop.Foreground = Brushes.Black;
                        break;

                    case 5:
                        x = Convert.ToDouble(number1.Text);
                        answer.Content = Math.Round(Math.Cos(x));
                        dop.Content = "Число для подсчета вводиться в первое поле";
                        dop.Foreground = Brushes.Black;
                        break;

                    case 6:
                        x = Convert.ToDouble(number1.Text);
                        answer.Content = Math.Round(Math.Tan(x));
                        dop.Content = "Число для подсчета вводиться в первое поле";
                        dop.Foreground = Brushes.Black;
                        break;

                    case 7:
                        x = Convert.ToDouble(number1.Text);
                        answer.Content = Math.Round(1 / Math.Tan(x));
                        dop.Content = "Число для подсчета вводиться в первое поле";
                        dop.Foreground = Brushes.Black;
                        break;
                }
            }

            catch
            {
                answer.Content = "Введите число для подсчета в первое полe";
            }
        }
        // задание 4
        private void check_Click_1(object sender, RoutedEventArgs e)
        {
            string pass = "12345";
            if (pass == password.Text)
            {
                otvet.Content = "Верный пароль";
                otvet.Background = Brushes.Green;
            }
            else
            {
                otvet.Content = "Неверный пароль, попробуйте еще";
                otvet.Background = Brushes.Red;
            }
        }
    }
            

        
}
