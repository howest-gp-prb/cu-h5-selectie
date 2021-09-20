using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Prb.Raadspel.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int teRaden;
        int pogingen;
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            teRaden = rnd.Next(1, 11);
            Debug.WriteLine("Te raden: " + teRaden);
            pogingen = 0;
        }

        private void BtnGok_Click(object sender, RoutedEventArgs e)
        {
            int gok = int.Parse(txtGok.Text);
            if (gok == teRaden)
            {
                pogingen++;
                lblGokjes.Content = "Je hebt het getal " + teRaden + " geraden na " + pogingen + " pogingen";
            }
            else
            {
                lblGokjes.Content += gok.ToString() + Environment.NewLine;
                txtGok.Text = "";
                txtGok.Focus();
                pogingen++;
            }
        }
    }
}
