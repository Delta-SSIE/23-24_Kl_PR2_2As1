using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _06_WPF_03_O_Deset_Vic
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
            AddTenAndWrite();
        }

        private void InputTB_TextChanged(object sender, TextChangedEventArgs e) { }
        //private void InputTB_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (OutputTB == null)
        //        return;

        //    AddTenAndWrite();
        //}

        private void AddTenAndWrite()
        {
            if (double.TryParse(InputTB.Text, out double number))
            {
                number += 10;
                OutputTB.Text = number.ToString();

                InputTB.Background = Brushes.White;
                InputTB.Foreground = Brushes.Black;
            }
            else
            {
                OutputTB.Text = "N/A";

                InputTB.Background = Brushes.Red;
                InputTB.Foreground = Brushes.White;
            }
        }
    }
}