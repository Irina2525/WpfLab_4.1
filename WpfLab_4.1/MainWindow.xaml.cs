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

namespace WpfLab_4._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateDol.Text);
            double sumDollar = Convert.ToDouble(sumDol.Text);
            double resDouble = rateDollar* sumDollar;
            resSumDol.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateEur.Text);
            double sumEuro = Convert.ToDouble(sumEur.Text);
            double resDoubleEuro = rateEuro * sumEuro;
            resSumEuro.Text = resDoubleEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rateGrivn.Text);
            double sumGrivna = Convert.ToDouble(sumGrivn.Text);
            double resDoubleGrivna = rateGrivna * sumGrivna;
            resSumGrivn.Text = resDoubleGrivna.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateArmDrama = Convert.ToDouble(rateArmDram.Text);
            double sumArmDrama = Convert.ToDouble(sumArmDram.Text);
            double resDoubleArmDram = rateArmDrama * sumArmDrama;
            resSumArmDram.Text = resDoubleArmDram.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            const double rateDyuymConst = 0.0254;
            double rateDyuymy = Convert.ToDouble(rateDyuym.Text);
            double resDyuymy = rateDyuymConst * rateDyuymy;
            resSumDyuym.Text = resDyuymy.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            const double rateFootConst = 0.3048;
            double rateFeet = Convert.ToDouble(rateFoot.Text);
            double resDyuymy = rateFootConst * rateFeet;
            resSumFoot.Text = resDyuymy.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            const double rateMileConst=1609.34;
            double rateMile= Convert.ToDouble(rateMil.Text);
            double resMile= rateMileConst * rateMile;
            resSumMil.Text = resMile.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            const double rateVerstConst = 1066.8;
            double rateVersts = Convert.ToDouble(rateVerst.Text);
            double resVerst = rateVerstConst * rateVersts;
            resSumVerst.Text = resVerst.ToString();
        }
    }
}
