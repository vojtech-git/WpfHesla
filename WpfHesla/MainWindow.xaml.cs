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
using System.Text.RegularExpressions;

namespace WpfHesla
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void switchFormButton_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"^(?=.*\d).{6,15}$");

            if (inputJmeno.Text == "" || inputHeslo.Text == "")
            {
                MessageBox.Show("Nezadal jste heslo nebo jméno.");
            }
            else if (regex.IsMatch(inputHeslo.Text))
            {
                MessageBox.Show("Byl jste prihlášen.");
            }            
            else
            {
                MessageBox.Show("Špatny formát hesla.");
            }
        }
    }
}
