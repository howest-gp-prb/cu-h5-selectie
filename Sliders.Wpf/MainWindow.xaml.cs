using System.Windows;

namespace Sliders.Wpf
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
            int getal1 = (int)sldGetal1.Value;
            int getal2 = (int)sldGetal2.Value;
            string boodschap = "";

            if (getal1 == getal2)
            {
                boodschap = "eerste = tweede";
            }
            else if (getal1 < getal2)
            {
                boodschap = "eerste < tweede";
            }
            else
            {
                boodschap = "eerste > tweede";
            }

            lblBoodschap.Content = boodschap;
        }
    }
}
