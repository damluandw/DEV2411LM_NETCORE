using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    internal class Employee
    {
        private int id;
        private string name;
        private int age;

        //Khai báo contruster
        public Employee() {
            this.id = 0;
            this.name = "";
            this.age = 0;
        }
        //Khai báo contruster có tham số
        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        ~Employee()
        {
            Console.WriteLine("Đối tượng đã bị huỷ");
        }

        //Thuộc tính chỉ đọc
        //chỉ có đọc dữ liệu mà không được ghi dữ liệu
        public int ID { get { return id; } }

        //Thuộc tính chỉ ghi
        // chi cho dữ liệu được ghi mà không lấy được dữ liệu ra
        public string Name { set { name = value; } }

        //Thuộc tính được đọc/ghi
        public int Age { 
            get { return age; } 
            set { age = value; }
        }

        //Phương thức display
        public void Display()
        {
            //id = 9;
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Age: " + age);
        }

    }
}
