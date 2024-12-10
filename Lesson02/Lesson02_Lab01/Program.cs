using System.Text;

namespace Lesson02_Lab01
{
    internal class Program
    {
        /// <summary>
        /// Chương trình minh hoạ về nhập xuất dữ liệu
        /// Nhập mã sinh viên, tên sinh viên, ngày sinh và điểm 3 môn
        /// In ra thông tin sinh viên và điểm trung bình
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Input và oput theo định đạng unicode(tiếng việt)
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //Khai báo biến
            string MSV, tenSV;
            DateTime ngaySinh;
            double diem1,diem2,diem3;

            // Yêu cầu người nhập thông tin
            // In ra màn hình yêu cầu nhập mã sinh viên
            Console.Write("Nhập mã sinh viên:");
            // Đọc dữ liệu vừa nhập và gán giá trị bằng MSV
            MSV = Console.ReadLine();
            // In ra ngoài màn hình yêu cầu nhập tên sinh viên
            Console.Write("Nhập tên sinh viên:");
            // Đọc dữ liệu vừa nhập và gán giá trị bằng tenSV
            tenSV = Console.ReadLine();
            // In ra ngoài màn hình yêu cầu nhập ngày sinh
            Console.Write("Nhập ngày sinh:");
            // Đọc dữ liệu vừa nhập và convert sang định dạng datetime rồi gán giá trị bằng ngày sinh
            ngaySinh = Convert.ToDateTime(Console.ReadLine());
            // In ra ngoài màn hình yêu cầu nhập điểm 1
            Console.Write("Nhập điểm môn 1:");
            // Đọc dữ liệu vừa nhập và convert sang định dạng Double rồi gán giá trị bằng diem1
            diem1 = Convert.ToDouble(Console.ReadLine());
            // In ra ngoài màn hình yêu cầu nhập điểm 2
            Console.Write("Nhập điểm môn 2:");
            // Đọc dữ liệu vừa nhập và convert sang định dạng Double rồi gán giá trị bằng diem2
            diem2 = Convert.ToDouble(Console.ReadLine());
            // In ra ngoài màn hình yêu cầu nhập điểm 3
            Console.Write("Nhập điểm môn 3:");
            // Đọc dữ liệu vừa nhập và convert sang định dạng Double rồi gán giá trị bằng diem3
            diem3 = Convert.ToDouble(Console.ReadLine());

            double diemTB = (diem1 + diem2 + diem3) / 3;
            Console.WriteLine("MSV:{0} -Họ tên: {1} - Ngày sinh: {2:dd/MM/yyyy} -Điểm trung bình: {3:F2} ",MSV,tenSV,ngaySinh, diemTB);

        }
    }
}
