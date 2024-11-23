namespace Lesson02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte age = 18;
            //Chuyển đổi dữ liệu ngầm định
            int age2 = age;
            Console.WriteLine("age2: {0}", age2);
            // chuyển đổi tường minh
            //age = Convert.ToByte(age2);
            //age2 = Convert.ToInt32(age);
            age = (byte)age2;
            Console.WriteLine("age: {0}", age);



            float age3 = 18.5F;
            Console.WriteLine("age3: {0}", age3);
            Console.WriteLine("age: {0}", age);

            age = (byte)age3;
            Console.WriteLine("age sau khi gán bằng age3: {0}", age);
            Console.ReadKey();
        }
    }
}
