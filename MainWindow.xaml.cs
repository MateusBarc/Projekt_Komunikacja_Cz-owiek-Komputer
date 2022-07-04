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

namespace Dietetyka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Main_Navigated()
        {

        }

        private void BtnClickZD(object sender, RoutedEventArgs e)
        {
            Main.Content = new WidokD();
        }

        private void BtnClickZK(object sender, RoutedEventArgs e)
        {
            Main.Content = new WidokK();
        }

        private void BtnClickPD(object sender, RoutedEventArgs e)
        {
            Main.Content = new PlanJedzenia();
        }

        private void BtnClickCK(object sender, RoutedEventArgs e)
        {
            Main.Content = new Czat();
        }

        private void BtnClickHD(object sender, RoutedEventArgs e)
        {
            Main.Content = new HarmonogramJedzenia();
        }

        private void BtnClickCD(object sender, RoutedEventArgs e)
        {
            Main.Content = new Czat();
        }
    }
}
