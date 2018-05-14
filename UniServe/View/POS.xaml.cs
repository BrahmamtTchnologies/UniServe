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

namespace UniServe.View
{
    /// <summary>
    /// Interaction logic for POS.xaml
    /// </summary>
    public partial class POS : UserControl
    {
        public POS()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WpfApplication1.POS.DayOpen obj = new WpfApplication1.POS.DayOpen();
            obj.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WpfApplication1.POS.DayClose obj = new WpfApplication1.POS.DayClose();
            obj.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WpfApplication1.POS.OrderBooking obj = new WpfApplication1.POS.OrderBooking();
            obj.Show();
        }
    }
}
