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
            string userName = UserNameTextBox.Text;
            MessageBox.Show("User Name :" + userName);
            // mặc định là oke
            MainWindow myCV = new MainWindow();// cửa sổ tốn vùng ram nhưng chưa render
                                               // myCV đổi các infor của object, của cửa sổ, đổi màu, đổi chữ title, vị trí
                                               //render thoy

            // myCV.Show(); // mở kiểu này thì mở dc nhiều cửa sổ, vậy mở nhiều cửa sổ như này thì ta sẽ khó kiểm soát, ví dụ đây là 1 màn hình add new user, ta add 50 màn hình add mới thì sẽ khó kiểm soát, ta quyết định tại 1 thời điểm mở 1 cửa sổ thì chỉ mở 1 cửa sổ thoi, chế độ mở 1 cửa sổ gọi là show theo style - giao tiếp lắng nghe - dialog
            myCV.ShowDialog();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Do You Really Want To Exit???", "Logout", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
            {
                // tắt app thoi
                Application.Current.Shutdown();
            }
        }
    }
}
