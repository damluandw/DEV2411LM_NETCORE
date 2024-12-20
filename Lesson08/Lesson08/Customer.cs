using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08
{
    internal class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public Customer(int id, string name, string city, int age) { 
            this.Id = id;
            this.Name = name;
            this.City = city;
            this.Age = age;
        }

        public override string ToString()
        {
            return Id + "|" + Name + "|" + City + "|" + Age;
        }
    }

    internal class Province
    {
        public string City { get; set; }
        public int Capacity { get; set; }

        public Province( string city, int capacity)
        {
            this.City = city;
            this.Capacity = capacity;
        }

        public override string ToString()
        {
            return City + "|" + Capacity;
        }
    }
}
