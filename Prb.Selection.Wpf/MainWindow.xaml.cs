using System;
using System.Windows;

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
            int hour = 19;
            bool evening = (hour >= 18) && (hour <= 22);
            MessageBox.Show("Om " + hour + " uur: " + evening, "Is het al avond?");
        }

        private void IsNight()
        {
            int hour = 23;
            bool night = (hour > 22) || (hour < 6);
            MessageBox.Show("Om " + hour + " uur: " + night, "Is het nacht?");
        }

        private void BtnTestBool_Click(object sender, RoutedEventArgs e)
        {
            bool areYourReady = false;
            MessageBox.Show(areYourReady.ToString(), "Ben je klaar?");
        }

        private void BtnTestNot_Click(object sender, RoutedEventArgs e)
        {
            bool areYouReady = false;
            areYouReady = !areYouReady;
            MessageBox.Show(areYouReady.ToString(), "Ben je klaar?");
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
            string dayName;
            DateTime currentDate = DateTime.Now;
            DayOfWeek currentDay = currentDate.DayOfWeek;
            if (currentDay == DayOfWeek.Sunday)
                dayName = "zondag";
            else if (currentDay == DayOfWeek.Monday)
                dayName = "maandag";
            else if (currentDay == DayOfWeek.Tuesday)
                dayName = "dinsdag";
            else if (currentDay == DayOfWeek.Wednesday)
                dayName = "woensdag";
            else if (currentDay == DayOfWeek.Thursday)
                dayName = "donderdag";
            else if (currentDay == DayOfWeek.Friday)
                dayName = "vrijdag";
            else dayName = "zaterdag";
            MessageBox.Show("Vandaag is het " + dayName, "Dag van de week");
        }

        private void BtnTicketPrice_Click(object sender, RoutedEventArgs e)
        {
            int age = 30;
            int ticketPrice;
            string beroep = "ambtenaar";

            if (beroep == "werkloos" || beroep == "gepensioneerd")
            {
                ticketPrice = 0;
            }
            else
            {
                if (age < 12)
                {
                    ticketPrice = 0;
                }
                else
                {
                    ticketPrice = 12;
                }
            }

            MessageBox.Show("De prijs van je ticket bedraagt: " + ticketPrice + " euro");
        }

        private void BtnWeekDaySwitch_Click(object sender, RoutedEventArgs e)
        {
            string dayName;
            DateTime currentDate = DateTime.Now;
            DayOfWeek currentDay = currentDate.DayOfWeek;
            switch (currentDay)
            {
                case DayOfWeek.Sunday:
                    dayName = "zondag";
                    break;
                case DayOfWeek.Monday:
                    dayName = "maandag";
                    break;
                case DayOfWeek.Tuesday:
                    dayName = "dinsdag";
                    break;
                case DayOfWeek.Wednesday:
                    dayName = "woensdag";
                    break;
                case DayOfWeek.Thursday:
                    dayName = "donderdag";
                    break;
                case DayOfWeek.Friday:
                    dayName = "vrijdag";
                    break;
                default:
                    dayName = "zaterdag";
                    break;
            }
            MessageBox.Show("Vandaag is het " + dayName, "Dag van de week");
        }
    }
}
