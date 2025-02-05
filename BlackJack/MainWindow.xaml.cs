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

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] karten = {7,8,9,10,10,10,10,11,
            7, 8, 9, 10, 10, 10, 10, 11,
            7, 8, 9, 10, 10, 10, 10, 11,
            7, 8, 9, 10, 10, 10, 10, 11};
        int spielerP = 0;
        int schmidtiP = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void weitereKarte(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(karten.Length);
            spielerP = spielerP + karten[i];
            if (spielerPunkte.Content.Equals(""))
            {
                spielerPunkte.Content = karten[i];
            }
            else
            {
                spielerPunkte.Content = spielerPunkte.Content + "+" + karten[i];
            }
        }
    }
}