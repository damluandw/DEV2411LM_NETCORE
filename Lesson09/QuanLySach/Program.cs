using System.Text;

namespace QuanLySach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xây dựng 1 chương trình quản lý sách
            // 1. Xây dựng class Sách, Nhà xuất bản, Tác giả
            // 1.1. class sách gồm các trường: Id, tên_sách, id_tác_giả, id_nhà_xuất_bản,
            //          năm_xuất_bản, số_trang
            //      class Nhà xuất bản gồm các trường: Id,tên_nhà_xuất_bản
            //      class Tác giả gồm các trường: Id,tên_tác_giả
            // 1.2. Xây dựng các contructor, phương thức hiển thị và nhập xuất dữ liệu
            // 2. Xây dựng chức năng quản lý và nhập xuất xoá dữ liệu
            //     thông tin Tác giả, Nhà xuất bản, sách
            // 3. Hiển thị dữ liệu ra ngoài màn hình
            //    3.1. Hiển thị tất cả sách
            //    3.2. Hiển thị theo group tác giả
            //    3.3. Tìm kiếm theo tên sách
            //    3.4. Tìm kiếm theo id tác giả 
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<TacGia> tacGia = new List<TacGia>()
            {
                new TacGia("TG01", "Tác giả 01"),
                new TacGia("TG02", "Tác giả 02"),
                new TacGia("TG03", "Tác giả 03"),
                new TacGia("TG04", "Tác giả 04"),
                new TacGia("TG05", "Tác giả 05"),
                new TacGia("TG06", "Khoa học "),
            };
            List<NhaXuatBan> nhaXuatBan = new List<NhaXuatBan>()
            {
                new NhaXuatBan("NXB01", "Nhà xuất bản 01"),
                new NhaXuatBan("NXB02", "Nhà xuất bản 02"),
                new NhaXuatBan("NXB03", "Nhà xuất bản 03"),
                new NhaXuatBan("NXB04", "Nhà xuất bản 04"),
                new NhaXuatBan("NXB04", "Nhà xuất bản 04"),
                new NhaXuatBan("NXB05", "Nhà xuất bản 05"),
                new NhaXuatBan("NXB06", "Khoa học "),
            };

            List<Sach> sach = new List<Sach>(){
                    new Sach("B01","Sách 1", "NXB01","TG01",1998,2642),
                    new Sach("B02","Sách 2", "NXB02","TG02",1997,2011),
                    new Sach("B03","Sách 3", "NXB03","TG03",2009,199),
                    new Sach("B04","Sách 4", "NXB04","TG04",2004,220),
                    new Sach("B05","Sách 5", "NXB05","TG05",2000,224),
                    new Sach("B06","Sách 6", "NXB06","TG06",2014,229),
                    new Sach("B07","Sách 7", "NXB01","TG02",2016,500),
                    new Sach("B08","Sách 8", "NXB02","TG02",2014,4222),
                    new Sach("B09","Sách 9", "NXB01","TG03",2015,2103),
            };

            var kt = true;
            int n =0;
            do
            {
                try
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Chào mừng bạn đến với chương trình quản lý sách");
                    Console.WriteLine("1. Nhập thông tin");
                    Console.WriteLine("2. Hiển thị dữ liệu");
                    Console.WriteLine("3. Xoá");
                    Console.WriteLine("4. Thoát");
                    Console.WriteLine("Vui lòng chọn từ 1 đến 3");
                    n = Convert.ToInt16(Console.ReadLine());
                    int loai = 0;
                    switch (n)
                    {
                        case 1:
                            
                            Console.WriteLine("----------------------");
                            Console.WriteLine("1. Nhập thông tin nhà xuất bản");
                            Console.WriteLine("2. Nhập thông tin tác giả");
                            Console.WriteLine("3. Nhập thông tin sách");
                            loai = Convert.ToInt16(Console.ReadLine());
                            switch (loai)
                            {
                                case 1:
                                    NhaXuatBan obj = new NhaXuatBan();
                                    obj.Nhap();
                                    nhaXuatBan.Add(obj);
                                    break;
                                case 2:
                                    TacGia obj2 = new TacGia();
                                    obj2.Nhap();
                                    tacGia.Add(obj2);
                                    break;
                                case 3:
                                    Sach obj3 = new Sach();
                                    obj3.Nhap();
                                    sach.Add(obj3);
                                    break;
                                default:
                                    Console.WriteLine("Vui lòng chọn từ 1 đến 3");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("1. Hiện thông tin nhà xuất bản");
                            Console.WriteLine("2. Hiện thông tin tác giả");
                            Console.WriteLine("3. Hiện thông tin sách");
                            Console.WriteLine("4. Hiện thông tin sách theo group tác giả");
                            Console.WriteLine("5. Tìm kiếm theo tên sách ");
                            Console.WriteLine("6. Tìm kiếm sách theo id tác giả ");
                            Console.WriteLine("7. Thoát");
                            loai = Convert.ToInt16(Console.ReadLine());
                            switch (loai)
                            {
                                case 1:
                                    foreach(var obj in nhaXuatBan)
                                    {
                                        Console.WriteLine(obj.ToString());
                                    }
                                    break;
                                case 2:
                                    foreach (var obj in tacGia)
                                    {
                                        Console.WriteLine(obj.ToString());
                                    }
                                    break;
                                case 3:
                                    foreach (var obj in sach)
                                    {
                                        Console.WriteLine(obj.ToString());
                                    }
                                    break;
                                case 4:
                                    
                                    break;
                                case 5:

                                    break;
                                case 6:

                                    break;
                                default:
                                    Console.WriteLine("Vui lòng chọn từ 1 đến 7");
                                    break;
                            }

                            break;
                        case 3:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("1. Xoá thông tin nhà xuất bản");
                            Console.WriteLine("2. Xoá thông tin tác giả");
                            Console.WriteLine("3. Xoá thông tin sách");
                            loai = Convert.ToInt16(Console.ReadLine());
                            string id = "";
                            switch (loai)
                            {
                                
                                case 1:
                                    foreach (var obj in nhaXuatBan)
                                    {
                                        Console.WriteLine(obj.ToString());
                                    }
                                    Console.WriteLine("Chọn Id");
                                    id = Console.ReadLine();
                                    var obj1 = new NhaXuatBan();
                                    foreach (var obj in nhaXuatBan)
                                    {
                                        if (obj.Id.Equals(id))
                                        {
                                            obj1 = obj;
                                        }
                                    }

                                    nhaXuatBan.Remove(obj1);
                                    break;
                                case 2:
                                    foreach (var obj in tacGia)
                                    {
                                        Console.WriteLine(obj.ToString());
                                    }
                                    Console.WriteLine("Chọn Id");
                                    id = Console.ReadLine();
                                    var obj2 = new TacGia();
                                    foreach (var obj in tacGia)
                                    {
                                        if (obj.Id.Equals(id))
                                        {
                                            obj2 = obj;
                                        }
                                    }

                                    tacGia.Remove(obj2);
                                    break;
                                case 3:
                                    foreach (var obj in sach)
                                    {
                                        Console.WriteLine(obj.ToString());
                                    }
                                    Console.WriteLine("Chọn Id");
                                    id = Console.ReadLine();
                                    var obj3 = new Sach();
                                    foreach (var obj in sach)
                                    {
                                        if (obj.Id.Equals(id))
                                        {
                                            obj3 = obj;
                                        }
                                    }

                                    sach.Remove(obj3);
                                    break;
                                default:
                                    Console.WriteLine("Vui lòng chọn từ 1 đến 3");
                                    break;
                            }
                            break;
                        case 4:
                            kt = false;
                            break;
                        default:
                            Console.WriteLine("Vui lòng chọn từ 1 đến 4");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Vui lòng nhập số");
                }


            } while (kt);
        }
       
    }
}
