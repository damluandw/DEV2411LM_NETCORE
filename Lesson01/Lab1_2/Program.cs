namespace Lab1_2
{
    internal class Program
    {
        /// <summary>
        /// Chương trình minh hoạ về sử dụng biến, hằng số, kiểu dữ liệu
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int id = 1;
            string name = "Devmaster";
            byte age = 18;
            char gender = 'M';
            // khai báo hằng số
            const float percent = 100.50F;

            //Hiển thị dữ liệu
            Console.WriteLine("StudentID: {0}", id);
            Console.WriteLine("Name: {0} \nAge: {1}", name, age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("percent: {0}", percent);
            Console.Read();



        }
    }
}
