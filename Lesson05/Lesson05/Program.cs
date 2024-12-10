using System;
using System.Text;

namespace Lesson05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Person person = new Person();
            //Employee employee = new Employee();
            //employee.Work();
            //employee.Run();
            //employee.Speak();
            //Document document = new Document();
            //document.Read();
            ////document.Write();

            //Calculator calculator = new Calculator();
            //calculator.Sub(6, 5);
            //calculator.Sum(6, 7);
            //calculator.Div(6, 8);
            //calculator.Mul(6, 9);
            //Crocodie crocodie = new Crocodie();
            //crocodie.MarineAnimalEat();
            //crocodie.TerrestrialAnimalEat();


            Console.OutputEncoding = Encoding.Unicode;
            //Mảng
            //Mảng 1 chiều
            //Khai báo mảng 1 chiều
            int[] number;
            // khai báo mảng 1 chiều và khởi tạo số phần tử
            int[] number1 = new int[6];
            //khai báo mảng 1 chiều và khởi tạo giá trị
            int[] number2 = new int[] {1,3,5,7,4,9};
            int[] number3 = { 1, 3, 5, 7, 4, 9 };

            // truy cập vào các phần từ mảng
            // tên_mảng[chỉ_sô]

            Console.WriteLine("vi tri so 4 của mang number2[3]: {0}", number2[3]);

            //Lấy số lượng phần tử của mảng
            //tên_mảng.Length
            Console.WriteLine("Số lượng phần tử của mảng number2: {0}", number2.Length);
            Console.WriteLine("-----------------------------");

            //Duyệt mảng (sử dụng các vòng lặp để duyệt mảng)
            for (int i = 0; i < number2.Length; i++)
            {
                Console.WriteLine(i + " " + number2[i]);
            }
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < number2.Length; i++)
            {
                number2[i]++;
                Console.WriteLine(i + " " + number2[i]);
            }
            Console.WriteLine("-----------------------------");
            foreach(int nb in number2)
            {
                Console.WriteLine(nb);
            }

            // Khai báo mảng 2 chiều
            //2 chiều hình chữ nhật
            int[,] mang2chieu = new int[3,4];
            //khai báo mảng 2 chiều và khởi tạo giá trị
            int[,] mang2chieu2 =
            {
                { 3,5,6,9},
                {4,5,4,6 },
                {9,5,6,5},
            };
            Console.WriteLine("-----------------------------");
            // duyệt mảng 2 chiều hình chữ nhật
            for (int i = 0;i< mang2chieu2.GetLength(0); i++)
            {
                Console.Write("Dòng {0}: \t",i);
                for (int j = 0; j < mang2chieu2.GetLength(1); j++)
                {
                    Console.Write(mang2chieu2[i,j] + "\t");
                }
                Console.WriteLine();
            }
            //2 chiều zic zac
            int[][] mang2chieu3 = new int[3][];
            mang2chieu3[0] = new int[] {8,6,89,5,6 };
            mang2chieu3[1] = new int[] { 99, 55 };
            mang2chieu3[2] = new int[] {  42, 66, 76 };
            // duyệt mảng 2 chiều zic zac
            Console.WriteLine("-----------------------------");
            for (int i = 0;i< mang2chieu3.GetLength(0); i++)
            {
                Console.Write("Dòng {0}: \t", i);
                for (int j = 0; j< mang2chieu3[i].Length; j++)
                {
                    Console.Write(mang2chieu3[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");
            //Array
            int[] numbers = new int[] {65,52,11,15,23,55,88,11 };
            // Array Sort - sắp xếp
            //Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("ví trị thứ "+ i + ":\t" + numbers[i]);
            }

            //Phương thức đảo ngược 
            Array.Reverse(numbers);
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("ví trị thứ " + i + ":\t" + numbers[i]);
            }

            //Tìm kiếm trong Array
            Console.WriteLine("-----------------------------");
            int index1 = Array.IndexOf(numbers, 11);
            int index2 = Array.LastIndexOf(numbers, 11);

            Console.WriteLine("ví trị của số "+ numbers[index1] +" sử dụng IndexOf:" + index1 );
            Console.WriteLine("ví trị của số " + numbers[index2] + " sử dụng LastIndexOf:" + index2);
            Console.WriteLine("-----------------------------");
            //Thay đổi số phần tử
            Console.WriteLine("Số lượng phần tử trong mảng numbers: " + numbers.Length);
            //numbers[8] = 55;
            Array.Resize<int>(ref numbers,9);
            Console.WriteLine("Số lượng phần tử trong mảng numbers sau khi resize: " + numbers.Length);
            numbers[8] = 55;
        }
    }
}
