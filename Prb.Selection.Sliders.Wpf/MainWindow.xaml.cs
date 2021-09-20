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
