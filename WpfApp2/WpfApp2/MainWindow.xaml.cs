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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            
            if (rnd.Next(1, 5)==1)
            {
                cheburash.Text = "Тепленькая пошла";
            }
            if (rnd.Next(1, 5) == 2)
            {
                cheburash.Text = "Я не сруля";

            }
            if (rnd.Next(1, 5) == 3)
            {
                cheburash.Text = "Пусть бегут неуклюже";
            }
            if (rnd.Next(1, 5) == 4)
            {
                cheburash.Text = "Ой, чебурахнулся";
            }

        }
    }
}
