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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int dodawanie = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void plus1_Click(object sender, RoutedEventArgs e)
        {
            dodawanie++;
            labelplus1.Content = dodawanie;
        }
    }
}