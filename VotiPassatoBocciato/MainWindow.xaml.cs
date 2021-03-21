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

namespace VotiPassatoBocciato
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double voto1 = double.Parse(txtVoto1.Text);
            double voto2 = double.Parse(txtVoto2.Text);
            double voto3 = double.Parse(txtVoto3.Text);
            double voto4 = double.Parse(txtVoto4.Text);
            if (voto1 > 10 || voto1 < 2 || voto2 > 10 || voto2 < 2 || voto3 > 10 || voto3 < 2 || voto4 > 10 || voto4 < 2)
            {
                MessageBox.Show("Voto non valido!", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                try
                {


                   
                    double totale = 0;
                    totale += voto1 + voto2 + voto3 + voto4;
                    double media = totale / 4;
                    txtMedia.Text = media.ToString();                    
                    if (media >= 6)
                        lblPromossoBocciato.Content = "Promosso";
                    else
                        lblPromossoBocciato.Content = "Bocciato";

                    double max1 = Math.Max(voto1, voto2);
                    double max2 = Math.Max(voto3, voto4);
                    double maxGenerale = Math.Max(max1, max2);
                    txtMax.Text = maxGenerale.ToString();

                    double min1 = Math.Min(voto1, voto2);
                    double min2 = Math.Min(voto3, voto4);
                    double minGenerale = Math.Max(min1, min2);
                    txtMin.Text = minGenerale.ToString();

                }
                catch (Exception ex)
                {
                    txtMedia.Text = ex.Message;
                }
            }
        }
    }
}
