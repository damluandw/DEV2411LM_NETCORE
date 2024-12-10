using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    internal class Animal
    {
        protected string food;
        protected string activity;
        public void Eat()
        {
            Console.WriteLine("Động vật ăn gì đó");
        }
        public void DoSomething()
        {
            Console.WriteLine("Động vật làm gì đó");
        }
        public Animal(string food, string activity)
        {
            this.food = food;
            this.activity = activity;
        }
    }

    // Kế thừa 
    internal class Cat: Animal
    {
        // kế thừa constructor
        public Cat():base ("","")
        {

        }
        public void Eat()
        {
            Console.WriteLine("Mèo ăn gì đó");
        }
        public void Action()
        {
            //Cat c = new Cat();
            //c.Eat();
            Eat();
            //kế thừa phương thức
            base.DoSomething();
            base.Eat();
        }

        public void Show()
        {
            food ="cá";
            activity = "chạy";
            Console.WriteLine("Mèo ăn " + food);
            Console.WriteLine("Mèo " + activity);
        }
    }
}
