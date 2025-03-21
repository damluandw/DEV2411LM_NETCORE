﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    internal class Person
    {
        int id;
        string name;
        int age;
        string phone;
        string adress;
        public Person(int id, string name, int age, string phone, string adress)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.adress = adress;
        }
        protected void Display()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("phone: " + phone);
            Console.WriteLine("adress: " + adress);
        }
    }
    internal class Staff: Person
    {

        int salary;
        public Staff(int id, string name, int age, string phone, string adress, int salary):base(id,name,age,phone,adress)
        {
            this.salary = salary;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("salary: " + salary);
        }
    }
}
