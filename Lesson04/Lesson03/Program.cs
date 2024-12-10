using System.Text;

namespace Lesson03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Nạp chồng phương thức
            //int tong= NopChong.Sum(1, 2);
            //Console.WriteLine("Phuong thuc int Sum,tong 1 và 2 là {0}", tong);
            //double tong2 = NopChong.Sum(1.23d, 2.56d);
            //Console.WriteLine("Phuong thuc double Sum, tong 1d và 2d là {0:0.#0}", tong2);
            //int tong3 = NopChong.Add(2, 3);
            //Console.WriteLine("Phuong thuc Add 2 tham so, tong là {0}", tong3);
            //int tong4 = NopChong.Add(1, 2,3);
            //Console.WriteLine("Phuong thuc Add 3 tham so, tong là {0}", tong4);

            //// Nạp chồng contructor
            //Student student = new Student();
            //student.ID = 1;
            //student.Name = "Test";
            //student.Age = 30;
            //student.Display();

            //Student student1 = new Student(3,"Devmaster", 20);
            //student1.Display();

            //Student student2 = new Student(3, "Devmaster");
            //student2.Display();
            Console.OutputEncoding = Encoding.Unicode;
            Cat cat = new Cat();
            cat.Action();
            cat.Show();

            Department department = new Department();
            department.Display();

            Staff staff = new Staff(1, "Devmaster", 10, "097131333", "25 Vũ Ngọc Phan", 3);
            staff.Display();
            Console.WriteLine("-------------------------------");
            SalaryEmployee2 salaryEmployee2 = new SalaryEmployee2("Devmaster",100000, 200000);
            Console.WriteLine("salaryEmployee2 CalPay: "+ salaryEmployee2.CalPay());
        }
    }
}
