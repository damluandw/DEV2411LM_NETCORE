using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLySach
{
    internal class NhaXuatBan
    {
        public string Id { get; set; }
        public string TenNhaXuatBan { get; set; }

        public NhaXuatBan() { }

        public NhaXuatBan(string id, string name)
        {
            Id = id;
            TenNhaXuatBan = name;
        }

        public void Nhap()
        {
            Console.Write("Nhập Id: ");
            Id = Console.ReadLine();
            Console.Write("Nhập Tên Nhà Xuất Bản: ");
            TenNhaXuatBan = Console.ReadLine();
            
        }

        public override string ToString()
        {
            return Id + " | " + TenNhaXuatBan;
        }
    }
}
