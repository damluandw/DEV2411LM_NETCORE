using System.Xml.Linq;

namespace Lesson03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Vòng lặp for
            //for(int i=0; i <= 10; i++)
            //{
            //    Console.WriteLine("Vòng lặp thứ: {0}", i);
            //}
            ////Do... while...

            //int j = 5;
            //do
            //{
            //    Console.WriteLine("Đây là vòng lặp do while");
            //    j++;
            //}while (j == 5);
            //j=5;
            //do
            //{
            //    Console.WriteLine("Đây là vòng lặp do while với j <7" );
            //    j++;
            //} while (j <7);
            //// While
            //j = 5;
            //while (j != 5)
            //{
            //    Console.WriteLine("Đây là vòng lặp while");
            //    j++;
            //} 
            //j = 5;
            //while (j < 7)
            //{
            //    Console.WriteLine("Đây là vòng lặp while với j <7");
            //    j++;
            //}

            ////foreach
            //int[] listInt = { 7, 3, 5, 10, 8, 22 };
            //foreach(int i in listInt)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 0; i < listInt.Length; i++)
            //{
            //    Console.WriteLine(listInt[i]);
            //}

            //Category category = new Category();
            //category.ID = 1;
            //category.Name = "Devmaster";
            //category.Display();
            //Console.WriteLine("Id: {0} \t Name: {1}", category.ID, category.Name);

            //Employee employee = new Employee();
            ////employee.ID = 2; //lỗi do thuộc tính ID chỉ đọc
            //employee.Name = "Devmaster";
            //employee.Age = 30;
            //employee.Display();

            //Console.WriteLine("Id: " + employee.ID);
            ////Console.WriteLine("Name: " + employee.Name); //lỗi do thuộc tính Name chỉ ghi
            //Console.WriteLine("Age: " + employee.Age);


            //Student student = new Student();
            //student.Mark1 = 6;
            //student.Mark2 = 7;
            //student.Mark3 = 8;
            //student.Id = 1;
            //student.Name = "Nguyen Van A";
            //student.Display();
            //double avg = student.Average();
            //Console.WriteLine("Diem trung binh la: {0}", student.Average());
            //Console.WriteLine("Diem trung binh la: {0}", avg);

            //int sum = student.Sum(1, 3);
            //double sum2 = student.Sum(1.4d, 4.5d);
            //Console.WriteLine("Tong 1: {0}", sum);
            //Console.WriteLine("Tong 2: {0}", sum2);


            //TestTinh.Id = 5;
            //TestTinh.Name = "Devmaster";
            //TestTinh.Display();

            ////TestTinh testTinh = new TestTinh();


            //int a = 10, b = 20;
            //double area;
            ////Truyền tham trị
            //Number.Swap(a,b);
            //Console.WriteLine("a: {0} \tb: {1}", a,b);
        
            ////Truyền tham chiếu
            //Number.Swap(ref a,ref b);
            //Console.WriteLine("a: {0} \tb: {1}", a, b);

            ////truyền tham chiếu với từ khoá out
            //Number.Cal(out area, 2);
            //Console.WriteLine("area: {0}", area);


            Employee employee = new Employee(3,"devmaster",4);
            employee.Display();

            Employee employee2 = new Employee();
        }
    }
}
