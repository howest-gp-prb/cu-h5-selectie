using System.Windows;

namespace Prb.Sliders.Wpf
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

        private void BtnTestSlider_Click(object sender, RoutedEventArgs e)
        {
            int number1 = (int)sldNumber1.Value;
            int number2 = (int)sldNumber2.Value;
            string message;

            if (number1 == number2)
            {
                message = "eerste = tweede";
            }
            else if (number1 < number2)
            {
                message = "eerste < tweede";
            }
            else
            {
                message = "eerste > tweede";
            }

            lblMessage.Content = message;
        }
    }
}
