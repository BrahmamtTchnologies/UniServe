﻿using System;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(this.txt_UserName.Text == "2" )
            {
                UniServe.MainWindow obj = new MainWindow();
                obj.Show();


            }
            else
            {
                MessageBox.Show("Invalid");
            }
                
                
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
