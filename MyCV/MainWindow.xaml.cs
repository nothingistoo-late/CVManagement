using MyCV.Entities;
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

namespace MyCV
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

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            // ta sẽ lấy cbi nhiều data đổ vào cái lưới 
            // data: đến từ data base 
            // cất trữ vào trong list<CV> List<Student>
            // cái lưới tên nó là CVListDataGrid rất là chuyên nghiệp, đằng sau nó chính là class CVListDataGrid chỉ cần đưa Data qua property. ItemsSource = list mình chuẩn bị, thế là nó tự generate colum, tự show data vào đúng hàng cột. Nếu mình có 1 List Student(id, name, yob, gpa), listCV(id, name, yob, position..) thì cái grid này tự biết tách cột tách dòng
            // mỗi sv, cv là 1 dòng của grid
            // cột trong sv, trong sv là cột của grid

            List<CV> arr = new();
            // hoặc là dùng mảng nhưng kh chơi mảng nữa
            arr.Add(new CV() { Id = "CFE01", Name = "An Nguyen", Yob = 2004, Position = "Front-end Intern" });
            arr.Add(new CV() { Id = "CBE01", Name = "Binh Le", Yob = 2004, Position = "Back-end Intern" });
            arr.Add(new CV() { Id = "CFTNET01", Name = "Chi Trung", Yob = 2004, Position = "Full-Stack .NET" });
            CVListDataGrid.ItemsSource = arr;
        }
    }
}