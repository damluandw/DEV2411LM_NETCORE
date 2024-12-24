using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    internal class TacGia
    {
        public string Id { get; set; }
        public string TenTacGia { get; set; }

        public TacGia() { }

        public TacGia(string id, string tenTacGia)
        {
            Id = id;
            TenTacGia = tenTacGia;
        }
        public void Nhap()
        {
            Console.Write("Nhập Id: ");
            Id = Console.ReadLine();
            Console.Write("Nhập Tên Tác Giả: ");
            TenTacGia = Console.ReadLine();

        }

        public override string ToString()
        {
            return Id + " | " +  TenTacGia;
        }
    }
}
