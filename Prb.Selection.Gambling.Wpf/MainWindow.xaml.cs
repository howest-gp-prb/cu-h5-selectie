using System;
using System.Diagnostics;
using System.Windows;

namespace Prb.Raadspel.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int toGuess;
        int attempts;
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            toGuess = rnd.Next(1, 11);
            Debug.WriteLine("Te raden: " + toGuess);
            attempts = 0;
        }

        private void BtnGuess_Click(object sender, RoutedEventArgs e)
        {
            int guess = int.Parse(txtGuess.Text);
            attempts++;

            if (guess == toGuess)
            {
                lblGuesses.Content = "Je hebt het getal " + toGuess + " geraden na " + attempts + " pogingen";
            }
            else
            {
                lblGuesses.Content += guess + Environment.NewLine;
                txtGuess.Text = "";
                txtGuess.Focus();
            }
        }
    }
}
