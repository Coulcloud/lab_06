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

namespace ll6
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
        private void GrayFont(object sender, RoutedEventArgs e)
        {
            text1.Style = (Style)Resources["GrayText"];
            text2.Style = (Style)Resources["GrayText"];
        }

        private void GreenFont(object sender, RoutedEventArgs e)
        {
            text1.Style = (Style)Resources["GreenText"];
            text2.Style = (Style)Resources["GreenText"];
        }

        private void DefaultFont(object sender, RoutedEventArgs e)
        {
            text1.Style = (Style)Resources["NormalText"];
            text2.Style = (Style)Resources["NormalText"];
        }

        private void Open(object sender, RoutedEventArgs e)
        {
            text1.Visibility = Visibility.Visible;
            text2.Visibility = Visibility.Visible;
        }

        private void Clean(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            if (text1.Text == "" & text2.Text == "")
            {
                text1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Hidden;
            }
            
        }
    }
}
