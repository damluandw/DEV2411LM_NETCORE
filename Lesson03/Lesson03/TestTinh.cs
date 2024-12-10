using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    internal static class TestTinh
    {
        public static int Id { get; set; } 
        public static string Name { get; set; }

        public  static void Display()
        {
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Name: {0}", Name);
        }
    }
}
