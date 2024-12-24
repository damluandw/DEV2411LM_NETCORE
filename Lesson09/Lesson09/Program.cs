namespace Lesson09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///I. Nhập xuất dữ liệu
            //1.1. Xuất dữ liệu theo dạng Console
            Console.WriteLine();
            //Đọc dữ liệu từ Console
            Console.ReadLine();

            ///II. Cấu trúc điều khiển
            //2.1. if else
            // - if
            //      if(mệnh_đề_điều_kiện){
            //          các_khối_lệnh
            //      }
            // - if else
            //      if(mệnh_đề_điều_kiện){
            //          các_khối_lệnh
            //      }else{
            //          các_khối_lệnh
            //      }
            // - if else if
            //      if(mệnh_đề_điều_kiện_1){
            //          các_khối_lệnh
            //      }else if(mệnh_đề_điều_kiện_2){
            //          các_khối_lệnh
            //      }
            //      ...
            //      else{
            //          các_khối_lệnh
            //      }
            // - if lồng if
            //      if(mệnh_đề_điều_kiện_1){
            //          các_khối_lệnh_1
            //          if(mệnh_đề_điều_kiện_2){
            //              các_khối_lệnh_2
            //          }
            //      }

            //2.2. switch case
            // switch(biến_tham_chiếu){
            //         case giá_trị_so_sánh_1: 
            //                  các_khối_lệnh_1;
            //                  break;
            //         case giá_trị_so_sánh_2: 
            //                  các_khối_lệnh_2;
            //                  break;
            //         case giá_trị_so_sánh_3: 
            //                  các_khối_lệnh_3;
            //                  break;
            //          ....
            //         default:
            //                  các_khối_lệnh_n+1;
            //                  break;      
            // }
            //
            //  
            ///III. Vòng lặp
            //3.1. Vòng lặp for
            // for( khởi_tạo_giá_trị_bắt_đầu; mệnh_đề_điều_kiện ; biến_tăng/biến_giảm){
            //      Các_khối_lệnh
            // }
            //3.2. vòng lặp do while
            // do{
            //      các_khối_lệnh
            // }while(mệnh_đề_điều_kiện)
            // 3.3. Vòng lặp While
            // while(mệnh_đề_điều_kiện){
            //      các_khối_lệnh
            // }


            /// IV. Class - Lớp
            // 4.1. Các thành phần của class
            //  - trường - private kiểu_dữ_liệu tên_trường
            //  - thuộc tính - bổ_từ_phạm_vi_sử_dụng kiểu_dữ_liệu tên_thuộc tính {get {return tên_trường;} set{tên_trường = value;}}
            // => public kiểu_dữ_liệu tên_thuộc_tính {get; set;}
            //  - contructor - public tên_lớp(){}
            //  - phương thức - bổ_từ_phạm_vi_sử_dụng kiểu_dữ_liệu tên_phương_thức()
            // 4.2. Khai báo lớp
            // bổ_từ_phạm_vi_sử_dụng class tên_class(){
            //      các_thành_phần_của_class
            // }

            // V. Kế thừa
            // 4.1. Cách kế thừa
            //  - sử dụng dấu :
            //  ví dụ: class1 kế thừa từ class2
            //          class1 : class2
            // 4.2. Các kiểu kế thừa
            // - kế thừa từ class,interface, abstract
            // + kế thừa đơn: class,interface, abstract
            // + đa kế thừa: interface, abstract

            /// VI. Đa hình
            // 6.1. Đa hình trong phương thức
            //  - tên_phương_thức trùng nhau
            //  - ít nhất 1 trong các yếu tố khác phải khác nhau:
            //      + giá trị trả về có thể khác nhau hoặc không
            //      + các kiểu giá trị và biến tham chiếu/biến tham trị phải khác nhau ở vị trí hoặc số lượng
            // 6.2. Đa hình trong contructor
            // - giống với đa hình trong phương thức là các kiểu giá trị và biến truyền vào phải khác nhau
            // ở vị trí hoặc số lượng

            /// VII. Lớp trừu tượng - abstract
            // 7.1. Các phương thức trong abstract
            //  - phương thức trừu tượng - có từ khoá abstract trong phương thức và phương thức k có nội dung
            //  - phương thức k trừu tượng - phương thức có nội dung và k có từ khoá abstract
            // 7.2. Lưu ý:
            // - để dử dụng phương thức trừu tượng thì class phải kế thừa từ lớp trừu tượng
            // và sử dụng từ khoá overidde để kế thừa phương thức
            ///VIII. Lớp giao diện - interface
            // 8.1. Các phương thức
            // - phương thức trừu tượng - phương thức k có nội dung
            // 8.2. Lưu ý
            // - để sử dụng thì class phải kế thừa từ lớp giao diện và k cần sử dụng từ khoá overidde
            // - bắt buộc phải kế thừa toàn bộ các phương thức trong lớp giao diện
            // - có thể đa kế thừa lớp giao diện

            /// IX. Mảng và chỉ mục
            //  9.1. Mảng
            //  - khai báo
            //  - gán giá trị
            //  - hiện thị giá trị
            //  - Một hàm liên quan đến mảng
            //  9.1.1. Mảng 1 chiều
            //  9.1.2. Mảng 2 chiều
            //  + Mảng 2 chiều ziczac
            //  + Mảng 2 chiều chữ nhật
            // 9.2. Chỉ mục

            /// X. Generic và Collection
            // 10.1. Generic
            // - Nhận tất các kiểu dữ liệu khác nhau
            // 10.1.1. ArrayList
            // 10.1.2. HashTable
            // 10.1.3. SortedList
            // 10.2. Collection
            // - Xác định kiểu dữ liệu
            // 10.2.1. List
            // 10.2.2. Dictionary
            // 10.2.3. SortedList

            /// XI. Namespace
            // - Đặt tên namespace
            // - 3 Sử dụng namespace
            //    + using tên_namespace => tên_class_sử_dụng
            //    + tên_namespace.tên_class_sử_dụng
            //    + tên_alias  = using tên_namespace => tên_alias.tên_class_sử_dụng
            /// XII. Xử lý ngoại lệ -Exception
            //  - try catch final

            /// XIII. LINQ
            // - LINQ
            // - LINQ mở rộng



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


        }
    }
}
