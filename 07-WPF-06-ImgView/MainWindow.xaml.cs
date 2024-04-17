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

namespace _06_WPF_06_ImgView
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

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            //vyvolat dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a picture";
            ofd.Filter =
                "All supported graphics|*.jpg;*.jpeg;*.png;*.bmp|"
                + "JPEG (*.jpg; *.jpeg)|*.jpg;*.jpeg|"
                + "PNG (*.png)|*.png";

            if (ofd.ShowDialog() != true)
                return; //ukončím načítání, byl cancel

            //zjistit výsledek
            string fileName = ofd.FileName;
            FileNameTB.Text = fileName;

            try
            {
                //načíst soubor
                Uri imageUri = new Uri(fileName);

                //předat image do control
                PhotoCtrl.Source = new BitmapImage(imageUri);
            }
            catch
            {
                MessageBox.Show("Error opening file", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}