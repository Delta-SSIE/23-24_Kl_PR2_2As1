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

namespace _07_WPF_01_Hello_World
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isHello;

        public MainWindow()
        {
            InitializeComponent();
            HelloLbl.Content = "Hello world!";
            HelloLbl.Foreground = Brushes.Black;
            _isHello = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_isHello)
            {
                HelloLbl.Content = "Goodbye world!";
                HelloLbl.Foreground = Brushes.Red;
            }
            else
            {
                HelloLbl.Content = "Hello world!";
                HelloLbl.Foreground = Brushes.Black;
            }
            _isHello = !_isHello;
        }
    }
}