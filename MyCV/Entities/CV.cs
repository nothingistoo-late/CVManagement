using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCV.Entities
{
    public class CV
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public string Position { get; set; } // FE, BE...


        // ta không làm toString() lý do là:
        // cái lưới nó tự trích ra từng colum qua cái hàm getProperty, ta đâu cần ghép chuỗi xong rồi lại mất công cắt
        // toString() hay dành cho debug, ghi log file, để kiểm tra data đúng sai lúc runtime!!!
        public CV() { }
    }
}
