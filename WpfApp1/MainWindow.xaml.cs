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
        byte R = 255;
        byte G = 255;
        byte B = 255;
        public MainWindow()
        {
            InitializeComponent();
            RedSlider.Value = R;
            GreenSlider.Value = G;
            BlueSlider.Value = B;

            RedSlider.ValueChanged += RedSliderChanged;
            GreenSlider.ValueChanged += GreenSliderChanged;
            BlueSlider.ValueChanged += BlueSliderChanged;
        }

        private void RedSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RedNumberValue.Content = Convert.ToInt32(RedSlider.Value).ToString();
            R = (byte)RedSlider.Value;
            ColorRectangle.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void GreenSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            GreenNumberValue.Content = Convert.ToInt32(GreenSlider.Value).ToString();
            G = (byte)GreenSlider.Value;
            ColorRectangle.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void BlueSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BlueNumberValue.Content = Convert.ToInt32(BlueSlider.Value).ToString();
            B = (byte)BlueSlider.Value;
            ColorRectangle.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void PobierzButton_Clicked(object sender, RoutedEventArgs e)
        {
            RGBNumberValue.Content = $"{Convert.ToInt32(RedSlider.Value)}, {Convert.ToInt32(GreenSlider.Value)}, {Convert.ToInt32(BlueSlider.Value)}";

            Color color = Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value);
            RGBNumberValue.Background = new SolidColorBrush(color);
        }
    }
}