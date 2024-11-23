using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    internal class Program
    {
        /// <summary>
        /// Chú thích kiểu XML
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            // Hiển thị ra ngoài màn hình
            Console.WriteLine("Hello word!!!");

            //Khai báo biến
            string name;
            /*
             * Chú thích nhiều dòng
             * Đoạn code sau sẽ yêu cầu bạn nhập tên của mình
             * Sau đó in ra màn hình
             */
            Console.Write("Nhập tên của bạn: ");
            // Đọc thông tin vừa nhập và gán giá trị name 
            name = Console.ReadLine();
            // Hiển thị tên vừa nhập ra ngoài màn hình
            Console.WriteLine("Tên của bạn là: " + name);
            Console.ReadKey();
        }
    }
}
