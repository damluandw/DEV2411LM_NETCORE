using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    internal class Student
    {
        //field
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // contructor
        // contructor không tham số
        public Student() {
            this.ID = 0;
            Name = "";
            Age = 0;
        }

        // conructor có tham số
        // Nạp chồng constructor
        public Student(int ID, string name)
        {
            this.ID = ID;
            this.Name = name;
        }

        // Nạp chồng constructor
        public Student(int id, string name, int age)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }

        // Nạp chồng constructor
        public Student( string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }



        // Phương thức
        public void Display()
        {
            Console.WriteLine("Id: {0} \tName: {1}",ID, Name);
            Console.WriteLine("Age: {0} ", Age);
        }
    }
}
