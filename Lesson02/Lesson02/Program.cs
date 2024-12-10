using System.Text;

namespace Lesson02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte age = 18;
            ////Chuyển đổi dữ liệu ngầm định
            //int age2 = age;
            //Console.WriteLine("age2: {0}", age2);
            //// chuyển đổi tường minh
            ////age = Convert.ToByte(age2);
            ////age2 = Convert.ToInt32(age);
            //age = (byte)age2;
            //Console.WriteLine("age: {0}", age);



            //float age3 = 18.5F;
            //Console.WriteLine("age3: {0}", age3);
            //Console.WriteLine("age: {0}", age);

            //age = (byte)age3;
            //Console.WriteLine("age sau khi gán bằng age3: {0}", age);
            //Console.ReadKey();

            //Nhập dữ liệu từ bàn phím sẽ đọc theo kiểu dữ liệu unicode
            Console.InputEncoding = Encoding.Unicode;
            //In ra ngoài màn hình theo kiểu dữ liệu unicode
            Console.OutputEncoding = Encoding.Unicode;
            /*
            //Khai báo biến
            string name;
            string adress;

            //In ra ngoài màn hình yêu cầu nhập tên
            Console.WriteLine("Nhập tên của bạn");
            // Đọc dữ liệu từ bàn phím và gán giá trị bằng biến name
            name = Console.ReadLine();
            // In ra ngoài màn hình yêu cầu nhập địa chỉ
            Console.WriteLine("Vui lòng nhập địa chỉ của bạn");
            adress = Console.ReadLine();

            //Hiển thị ra ngoài màn hình tên và địa chỉ đã nhập
            Console.WriteLine("Tên của bạn là: {1}\nĐịa chỉ của bạn là: {0}", adress, name);
            */

            /*
            byte age;
            age = 18;
            int age2;
            // gán giá trị ngầm định
            age2 = age;
            Console.WriteLine("age2: " + age2);


            age2 = 20;
            // gán giá trị theo kiểu tường minh
            age = (byte) age2;
            age = Convert.ToByte(age2);
            Console.WriteLine("age: " + age);

            Console.WriteLine("Nhập tuổi của bạn:");
            age = Convert.ToByte(Console.ReadLine());
            //age = Console.ReadLine();
            Console.WriteLine("Tuổi của bạn:" + age);
            */

            //Cấu trúc điều khiển
            //I. IF ELSE
            //1.1. If
            // Systax: if(mệnh_đề_điều_kiện) { Khối_lệnh_thực_thi}

            if (6 > 5) // Nếu số 6 lớn hơn số 5 thì thực hiện câu lệnh trong ngoặc xoắn
            {
                Console.WriteLine("Số 6 lớn hơn số năm");
            }

            //1.1. If else
            // Systax:
            // if(mệnh_đề_điều_kiện) { Khối_lệnh_thực_thi_1}
            // else { Khối_lệnh_thực_thi_2 }
            // Nếu mệnh_đề_điều_kiện đúng thì thực hiện hiện Khối_lệnh_thực_thi_1
            // Ngược lại thực hiện Khối_lệnh_thực_thi_2
            if(5 > 6)
            {
                Console.WriteLine("Số 5 lớn hơn số 6");
            }
            else
            {
                Console.WriteLine("Số 6 lớn hơn số năm");
            }
            //1.1. If ... else if ... else
            // Systax:
            // if(mệnh_đề_điều_kiện_1) { Khối_lệnh_thực_thi_1}
            // else if(mệnh_đề_điều_kiện_2) { Khối_lệnh_thực_thi_2 }
            // ...
            // else { Khối_lệnh_thực_thi_n }
            // Nếu mệnh_đề_điều_kiện_1 đúng thì thực hiện hiện Khối_lệnh_thực_thi_1
            // sau đó thoát khỏi cấu trúc điều kiện
            // Ngược lại nếu mệnh_đề_điều_kiện_2 đúng thì thực hiện hiện Khối_lệnh_thực_thi_2
            // sau đó thoát khỏi cấu trúc điều kiện ...
            // Nếu tất cả điều kiện bên trên đều sai thì sẽ thực hiện
            // khối lệnh trong else{ Khối_lệnh_thực_thi_n }

            int diem =8;

            if(diem > 8)
            {
                Console.WriteLine("Học sinh giỏi");
            }else if(diem > 6)
            {
                Console.WriteLine("Học sinh khá");
            }else if (diem > 4) {
                Console.WriteLine("Học sinh trung bình");
            }else
            {
                Console.WriteLine("Học sinh yếu");
            }
            //II. SWITCH
            // Systax:
            // switch (biến_tham_chiếu){
            //         case giá_trị_so_sánh_1:
            //                         khối_lệnh_thực_thi_1;
            //                         break;
            //         case giá_trị_so_sánh_2:
            //                         khối_lệnh_thực_thi_2;
            //                         break;
            //            ...
            //         case giá_trị_so_sánh_n:
            //                         khối_lệnh_thực_thi_n;
            //                         break;
            //         default: 
            //                         khối_lệnh_thực_thi_default;
            //                         break;
            //}
            // Nếu biến tham chiếu bằng giá_trị_so_sánh_1 thì sẽ thực hiện khối_lệnh_thực_thi_1
            // sau đó thực thi câu lệnh break để thoát khỏi vòng lặp
            // Ngược lại nếu sai thì biến_tham_chiếu so sánh giá_trị_so_sánh_2 nếu đúng
            // thì sẽ thực hiện khối_lệnh_thực_thi_2
            // Và tiếp như vậy đến khi hết giá_trị_so_sánh_n
            // Nếu so sánh với giá_trị_so_sánh_n vẫn sai thì sẽ thực hiện khối_lệnh_thực_thi_default
            // Chú ý: Nếu không có break thì sẽ thực thi chương trình sẽ thực thi từ giá_trị_so_sánh đúng
            // với biến_tham_chiếu đến khi có câu lệnh break
            int thang =16;
            switch (thang)
            {
                case 1:
                    Console.WriteLine("Tháng 1");
                    break;
                case 2:
                    Console.WriteLine("Tháng 2");
                    break;
                case 3:
                    Console.WriteLine("Tháng 3");
                    break;
                case 4:
                    Console.WriteLine("Tháng 4");
                    break;
                case 5:
                    Console.WriteLine("Tháng 5");
                    break;
                case 6:
                    Console.WriteLine("Tháng 6");
                    break;
                case 7:
                    Console.WriteLine("Tháng 7");
                    break;
                case 8:
                    Console.WriteLine("Tháng 8");
                    break;
                case 9:
                    Console.WriteLine("Tháng 9");
                    break;
                case 10:
                    Console.WriteLine("Tháng 10");
                    break;
                case 11:
                    Console.WriteLine("Tháng 11");
                    break;
                case 12:
                    Console.WriteLine("Tháng 12");
                    break;
                default:
                    Console.WriteLine("Số đưa vào không phải là tháng nào trong năm");
                    break;
            }
                

        }
    }
}
