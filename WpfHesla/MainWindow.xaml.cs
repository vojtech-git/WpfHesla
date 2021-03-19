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

namespace WpfHesla
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

        private void switchFormButton_Click(object sender, RoutedEventArgs e)
        {
            if (inputHeslo.Text == "heslo" && inputJmeno.Text == "jmeno")
            {
                MessageBox.Show("vojtech test text");
            }
            else
            {
                MessageBox.Show("spatny format jmena nebo hesla");
            }
        }
    }
}
