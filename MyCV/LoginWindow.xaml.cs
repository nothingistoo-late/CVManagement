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

namespace MyCV
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello Con To","xin chao mai fen!!",MessageBoxButton.OK,MessageBoxImage.Warning);
            // gọi cửa sổ mainwindow lên, cửa sổ này là một class nên ta dùng biến object và show như mọi class bth khác
        }
    }
}
