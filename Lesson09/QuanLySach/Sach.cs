using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    internal class Sach
    {
        public string Id { get; set; }
        public string TenSach { get; set; }
        public string IdNXB { get; set; }
        public string IdTG { get; set; }
        public int NamXuatBan { get; set; }
        public int SoTrang { get; set; }

        public Sach() { }

        public Sach(string id,string tenSach, string idNXB, string idTG, int namXuatBan, int soTrang)
        {
            Id = id;
            TenSach = tenSach;
            IdNXB = idNXB;
            IdTG = idTG;
            NamXuatBan = namXuatBan;
            SoTrang = soTrang;
        }

        public void Nhap()
        {
            Console.Write("Nhập Id: ");
            Id = Console.ReadLine();
            Console.Write("Nhập Tên Sách: ");
            TenSach = Console.ReadLine();
            Console.Write("Nhập Id Nhà xuất bản: ");
            IdNXB = Console.ReadLine();
            Console.Write("Nhập Id Tác giả: ");
            IdTG = Console.ReadLine();          
            Console.Write("Nhập Năm Xuất bản: ");
            NamXuatBan = Convert.ToInt32( Console.ReadLine());
            Console.Write("Nhập Số Trang: ");
            SoTrang = Convert.ToInt32(Console.ReadLine());

        }

        public override string ToString()
        {
            return Id + " | " + TenSach + " | " + IdNXB + " | " + IdTG + " | " + NamXuatBan +" | " +  SoTrang;
        }
    }
}
