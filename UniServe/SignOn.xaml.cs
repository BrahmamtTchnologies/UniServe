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
using System.Windows.Shapes;
using WPFTabTip;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            //Bind the virtual keybord to all textBox and PasswordBox
            TabTipAutomation.BindTo<TextBox>();
            TabTipAutomation.BindTo<PasswordBox>();
            // Ignore the all Hardware.
            TabTipAutomation.IgnoreHardwareKeyboard = HardwareKeyboardIgnoreOptions.IgnoreAll;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pnlcontent.Content = new UniServe.View.Login();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
