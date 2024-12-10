using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    internal class Category
    {
        // Khai báo các trường
        private int id;
        private string name;

        // Khai báo thuộc tính
        public int ID { 
            get { return id; } 
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Khai báo phương thức
        public void Display()
        {
            Console.WriteLine("Id: " +  id);
            Console.WriteLine("Name:" + name);
        }

    }
}
