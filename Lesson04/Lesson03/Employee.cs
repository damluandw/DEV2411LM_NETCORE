using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    internal class Employee
    {
        int id = 10;
        string name = "Devmaster";
        int age = 10;
        protected void Display()
        {
            Console.WriteLine("id: "+ id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
        }
    }

    internal class Department  :Employee
    {
        int idDepartment = 5;
        string nameDepartment = "Test";

        public new void Display()
        {
            base.Display();
            Console.WriteLine("idDepartment: " + idDepartment);
            Console.WriteLine("nameDepartment: " + nameDepartment);
        }
    }
}
