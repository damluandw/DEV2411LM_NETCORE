using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    /// <summary>
    /// Overloading
    /// </summary>
    internal static class NopChong
    {
        /// <summary>
        /// Phương thức Sum
        /// </summary>
        /// <param name="a">Số a</param>
        /// <param name="b">Số b</param>
        /// <returns>số a + số b</returns>
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        //Tên giống nhau, giá trị trả về khác nhau
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        // Tên giống nhau, số lượng tham số truyền vào khác nhau
        public  static int Add(int a, int b, int c)
        {
            return (a + b) + c;
        }

    }
}
