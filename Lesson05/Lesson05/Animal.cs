using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    internal class Animal
    {
        protected int id { get; set; }
        protected string name { get; set; }

        public Animal() {
            this.id = 0;
            this.name = "";
        }

        public Animal(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        protected void Display()
        {
            Console.WriteLine("id" + id);
            Console.WriteLine("name" + name);
        }

    }

    internal class Cat : Animal
    {
        public int leg { get; set; }

        public Cat() : base()
        {
            this.leg = 0;
        }

        public Cat(int id, string name, int leg) : base(id, name)
        {

        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("leg" + leg);
        }
    }
}
