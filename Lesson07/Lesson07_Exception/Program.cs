namespace Lesson07_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int number;
            // Console.WriteLine("Nhập vào một số: ");
            //number= Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(number);


            int a = 12, b = 0, c;
            int? d = null;
            try
            {
                c = a / b;
                Console.WriteLine(a + "/"  +b + " = " +c);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                c = a / b;
                Console.WriteLine(a + "/" + b + " = " + c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // trường hợp k bắt exception
            //try
            //{
            //    c = a / b;
            //    Console.WriteLine(a + "/" + b + " = " + c);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //nếu không biết thuộc exception nào
            try
            {
                c = a / b;
                Console.WriteLine(a + "/" + b + " = " + c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("devmaster");

            string[] names = { "devmaster", "Khoa", "Vương", "Quân", "Hải","Hương","Tiến" };
            // exception lồng nhau
            try
            {
                Console.WriteLine("Khối try catch ngoài");
                try
                {
                    c = a / b;
                    Console.WriteLine(a + "/" + b + " = " + c);
                }
                catch (ArithmeticException ex)
                {
                    Console.WriteLine("Khối try catch trong");
                    Console.WriteLine(ex.Message);
                }

                names[9] = "Anh";
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Khối try catch ngoài");
                Console.WriteLine(ex.Message);
            }

            //Nhiều khối catch
            //Lưu ý:
            // - Khối catch bên trên phải là tập con của khối catch bên dưới
            // - Hoặc khối catch bên dưới và khối catch bên trên là 2 tập khác nhau
            Console.WriteLine("----------------------------------");
            try
            {
                c = a / b;
                Console.WriteLine(a + "/" + b + " = " + c);
                names[9] = "Anh";
            }
            catch (IndexOutOfRangeException ex)
            {
                //logic 2
                Array.Resize<string>(ref names, 10);
                names[9] = "Khoa";
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                //logic 1
                b = 1;                
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("--------------------------------");
            //finally
            // 
            try
            {
                c = a / b;
                Console.WriteLine(a + "/" + b + " = " + c);
                //Array.Resize<string>(ref names, 10);
                names[9] = "Anh";
                Console.WriteLine(names[9]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Khối finally");
            }
            Console.WriteLine("--------------------------------");
            //Tự xây dựng Exception
            Product product = new Product();
            try
            {
                product.Price = -2;

            }catch(InvalidPriceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
