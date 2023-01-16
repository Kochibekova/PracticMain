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

namespace p2
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
        //int f = 0b101;
        //double d = 3.5;
        //char j = 'A';
        //string name = "Alisa";
        //bool choise = false;
        //byte bit = 105;
        //sbyte bit1 = -105;
        //long u = 0b101;
        //ulong l = 0xff;
        //short s1 = 102;
        //3 задание
        private void t3_Click(object sender, RoutedEventArgs e)
        {
            int photo = 52;
            int photoinrow = 3;
            int fullrow = photo / photoinrow;
            full.Content = fullrow;
            int overflow = photo % photoinrow;
            over.Content = overflow;
        }
        //4 задание
        int cristal = 0;
        private void Buuh_Click(object sender, RoutedEventArgs e)
        {
            double Gold = Convert.ToInt32(gold1.Text);
            if (Gold > 100)
            {
                Gold -= 109; cristal += 10;
                crictal.Content = $"Кол-во кристалов: {cristal}";
                crictal.Background = Brushes.Aqua;
                gold.Text = $"{Gold}";
            }
            else
            {
                gold1.Text = "Нет денег  для покупки :(";
                gold1.Background= Brushes.BlueViolet;
            }
        }

        private void yourtime_Click(object sender, RoutedEventArgs e)
        {
            int people = Convert.ToInt32(peoplee.Text);
            try
            {
                otvet.Content = $"Вы должны отстоять в очереди{people *10/60} часов {people * 10 % 60 } минут ";
                otvet.Foreground = Brushes.Chocolate;
            }
            catch
            {

            }
        }

        private void otvet2_Click(object sender, RoutedEventArgs e)
        {
            l.Content = (name.Text, age.Text, zodiak.Text, work.Text);
        }
    }
}
