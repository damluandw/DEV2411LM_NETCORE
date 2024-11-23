using System.Text;

namespace Lab1_1
{
    /// <summary>
    /// Chương trình đầu tiên
    /// Chương này  in ra thông tin giới thiệu về bản thân
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Câu lệnh in
            Console.WriteLine("Họ và tên: Đàm Luận");
            Console.WriteLine("Ngày sinh: 12/06/1997");
            Console.WriteLine("Địa chỉ: Vũ Ngọc Phan");
            Console.WriteLine("Điện thoại: 0316458787");

            //câu lệnh dừng màn hình và chờ
            Console.ReadLine();
        }
    }
}
