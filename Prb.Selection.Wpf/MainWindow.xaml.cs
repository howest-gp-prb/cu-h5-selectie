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

namespace Prb.Selectie.Wpf
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

        private void IsEvening()
        {
            int uur = 19;
            bool avond = (uur >= 18) && (uur <= 22);
            MessageBox.Show("Om " + uur + " uur: " + avond.ToString(), "Is het al avond?");
        }

        private void IsNight()
        {
            int uur = 23;
            bool nacht = (uur > 22) || (uur < 6);
            MessageBox.Show("Om " + uur + " uur: " + nacht.ToString(), "Is het nacht?");
        }

        private void BtnTestBool_Click(object sender, RoutedEventArgs e)
        {
            bool benjeklaar = false;
            MessageBox.Show(benjeklaar.ToString(), "Ben je klaar?");
        }

        private void BtnTestNot_Click(object sender, RoutedEventArgs e)
        {
            bool benjeklaar = false;
            benjeklaar = !benjeklaar;
            MessageBox.Show(benjeklaar.ToString(), "Ben je klaar?");
        }

        private void BtnCheckEvening_Click(object sender, RoutedEventArgs e)
        {
            IsEvening();
        }

        private void BtnCheckNight_Click(object sender, RoutedEventArgs e)
        {
            IsNight();
        }

        private void BtnWeekDay_Click(object sender, RoutedEventArgs e)
        {
            string dagNaam;
            DateTime momenteel = DateTime.Now;
            DayOfWeek dag = momenteel.DayOfWeek;
            if (dag == DayOfWeek.Sunday)
                dagNaam = "zondag";
            else if (dag == DayOfWeek.Monday)
                dagNaam = "maandag";
            else if (dag == DayOfWeek.Tuesday)
                dagNaam = "dinsdag";
            else if (dag == DayOfWeek.Wednesday)
                dagNaam = "woensdag";
            else if (dag == DayOfWeek.Thursday)
                dagNaam = "donderdag";
            else if (dag == DayOfWeek.Friday)
                dagNaam = "vrijdag";
            else dagNaam = "zaterdag";
            MessageBox.Show("Vandaag is het " + dagNaam, "Dag van de week");
        }

        private void BtnTicketPrice_Click(object sender, RoutedEventArgs e)
        {
            int leeftijd = 30;
            int ticketPrijs;
            string beroep = "ambtenaar";


            if (beroep == "werkloos" || beroep == "gepensioneerd")
            {
                ticketPrijs = 0;
            }
            else
            {
                if (leeftijd < 12)
                {
                    ticketPrijs = 0;
                }
                else
                {
                    ticketPrijs = 12;
                }
            }

            MessageBox.Show("De prijs van je ticket bedraagt: " + ticketPrijs + " euro");
        }

        private void BtnWeekDaySwitch_Click(object sender, RoutedEventArgs e)
        {
            string dagNaam;
            DateTime momenteel = DateTime.Now;
            DayOfWeek dag = momenteel.DayOfWeek;
            switch (dag)
            {
                case DayOfWeek.Sunday:
                    dagNaam = "zondag";
                    break;
                case DayOfWeek.Monday:
                    dagNaam = "maandag";
                    break;
                case DayOfWeek.Tuesday:
                    dagNaam = "dinsdag";
                    break;
                case DayOfWeek.Wednesday:
                    dagNaam = "woensdag";
                    break;
                case DayOfWeek.Thursday:
                    dagNaam = "donderdag";
                    break;
                case DayOfWeek.Friday:
                    dagNaam = "vrijdag";
                    break;
                default:
                    dagNaam = "zaterdag";
                    break;
            }
            MessageBox.Show("Vandaag is het " + dagNaam, "Dag van de week");
        }
    }
}
