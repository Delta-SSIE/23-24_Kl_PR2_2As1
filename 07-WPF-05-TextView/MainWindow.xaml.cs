using Microsoft.Win32;
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

namespace _06_WPF_07_TextView
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

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select text file";
            op.Filter = "Text files (*.txt)|*.txt";
            if (op.ShowDialog() == true)
            {
                try
                {
                    TextDisplay.Text = System.IO.File.ReadAllText(op.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Chyba čtení souboru", "Chyba čtení souboru", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}