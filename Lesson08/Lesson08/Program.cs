namespace Lesson08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///I. Namespace
            // cách sử dụng class/interface/astract 
            //C1: tên_namespace1.tên_namespace2.tên_class/tên_interface/tên_astract
            //C2: using tên_namespace;
            //    {
            //          tên_class thuộc tên_namespace ...
            //    }
            // C3:using tên_alias = tên_namespace;
            //    {
            //          tên_alias.tên_class ....
            //    }
            /// II. Xử lý ngoại lệ -  Exception
            // 1. try catch
            // systax:
            //      try{
            //          các_khối_lệnh_thực_thi_try
            //      }catch(trường_hợp_lỗi tên_lỗi)
            //      {
            //          các_khối_lệnh_thực_thi_catch - khi các_khối_lệnh_thực_thi_try mà lỗi thì khối catch sẽ được thực thi
            //      }
            // 2. try catch finally
            // systax:
            //      try{
            //          các_khối_lệnh_thực_thi_try
            //      }catch(trường_hợp_lỗi tên_lỗi)
            //      {
            //          các_khối_lệnh_thực_thi_catch - khi các_khối_lệnh_thực_thi_try mà lỗi thì khối catch sẽ được thực thi
            //      }finally{
            //          các_khối_lệnh_thực_thi_finally - các câu lệnh trong khối try hoặc khối catch thực thi xong
            //      }
            // 3. try catch catch
            // systax:
            //      try{
            //          các_khối_lệnh_thực_thi_try
            //      }catch(trường_hợp_lỗi_1 tên_lỗi)
            //      {
            //          các_khối_lệnh_thực_thi_catch_1 - khi các_khối_lệnh_thực_thi_try mà lỗi thì khối catch_1 sẽ được thực thi
            //      }catch(trường_hợp_lỗi_2 tên_lỗi){
            //          các_khối_lệnh_thực_thi_catch_2 - khi các_khối_lệnh_thực_thi_try mà lỗi và k nằm trong lỗi của catch_1
            //          thì khối catch_2 sẽ được thực thi
            //      }
            // 4. Tự định nghĩa lỗi - class sẽ phải kế thừa từ Exception


            ///LINQ
            Customer[] customer =
            {
                new Customer(1,"Dung", "Ha Noi", 20),
                new Customer(2,"Long", "Hai Phong", 19),
                new Customer(3,"Anh", "Ha Noi", 23),
                new Customer(4,"Hoa", "Vinh Phuc", 22),
            };

            Province[] provinces =
            {
                new Province("Ha Noi",100000),
                new Province("Hai Phong",120000),
                //new Province("Vinh Phuc",180000),
            };


            //LINQ to array
            //systax: 
            //  IEnumerable<kiểu_dữ_liệu> tên_biến = from tên_1 in tên_mảng
            //                                      where mệnh_đề_điều kiện
            //                                       select tên_1
            //lấy tất cả khách hàng
            IEnumerable<Customer> listCustomer = from c in customer select c;
            //duyệt và in ra
            foreach (var c in listCustomer) {
                Console.WriteLine(c.ToString());
            }
            //lấy tất cả khách hàng từ tuổi 19 đến 22
            IEnumerable<Customer> listCustomer1 = from c in customer where c.Age >= 19 & c.Age <= 22
                                                  select c;
            Console.WriteLine("---------------------------");
            //duyệt và in ra
            foreach (var c in listCustomer1)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("---------------------------");
            // lấy thông tin chung
            //systax: 
            //  IEnumerable<kiểu_dữ_liệu> tên_biến = from tên_1 in tên_mảng_1
            //                                      join tên_2 in tên_mảng_2 on tên_1.cột_chung equals tên_2.cột_chung
            //                                      where mệnh_đề_điều_kiện
            //                                       select new {
            //                                             tên_1.tên_cột_1,....,
            //                                             tên_2.tên_cột_1,....,
            //                                       }
            var list = from c in customer
                       join p in provinces on c.City equals p.City
                       select new
                       {
                           c.Name,
                           c.City,
                           c.Age,
                           p.Capacity
                       };
            foreach (var item in list)
            {
                Console.WriteLine(item.Name + "|" + item.City + "|" + item.Age + "|" + item.Capacity + "|");
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            /// LINQ mở rộng
            int[] numbers = { 4, 65, 5, 545, 65, 5, 12, 132, 154, 3, 45, 43, 156 };
            string[] words =
            {
                "Chỉ", "trích", "phê", "phán","người", "khác",
                "giống","như","con","chim","bồ","câu","đưa","thư",
                "bao","giờ", "cũng","quay","về","nơi","xuất","phát"
            };
            List<Film> films = new List<Film>()
            {
                new Film("F01","Tây du ký",155000),
                new Film("F02","Lật mặt 1",165000),
                new Film("F03","Lật mặt 2",175000),
                new Film("F04","Iron Man",205000),
                new Film("F05","Người nhện",185000),
                new Film("F06","The Flash",195000),
            };
            //Lọc số duy nhất trong tập số
            var queryNumber = numbers.Distinct();
            Console.WriteLine("Số phần tử trong queryNumber là: " + queryNumber.Count());
            //Đếm số phần tử k trùng nhau trong words
            var queryWord = words.Distinct().Count();
            Console.WriteLine("Số phần tử trong queryNumber là: " + queryWord);
            Console.WriteLine("---------------------------");
            //Lấy 5 phần tử đầu tiên trong dãy
            var queryNumber2 = numbers.Take(5);
            foreach(var number in queryNumber2)
            {
                Console.WriteLine(number);

            }
            Console.WriteLine("---------------------------");
            // bỏ 3 phần tử đầu và lấy 5 phần tử ở sau
            var queryNumber3 = numbers.Skip(3).Take(5);
            foreach (var number in queryNumber3)
            {
                Console.WriteLine(number);

            }
            Console.WriteLine("---------------------------");
            // bỏ 5 phần tử đầu và bỏ 3 phần tử đầu trong năm phần tử đó
            var queryNumber4 = numbers.Take(5).Skip(3);
            foreach (var number in queryNumber4)
            {
                Console.WriteLine(number);

            }
        }
    }
    public class Film {
        public string Id { get; set; }

        public string Name { get; set; }
        public float Price { get; set; }

        public Film() { }
        public Film(string id,string name, float price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
