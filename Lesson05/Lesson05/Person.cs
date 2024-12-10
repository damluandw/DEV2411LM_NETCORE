using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    public abstract class Person
    {
        //Phương thức không trừu tượng
        public void Speak()
        {
            Console.WriteLine("Nguoi VietNam noi tieng Viet");
        }
        // Phương thức trừu tượng
        public abstract void Work();
        public abstract void Run();

    }

    public class Employee : Person
    {
        public void Speak()
        {
           base.Speak();
        }
        public override void Work()
        {
            Console.WriteLine("Lam viec vat va");
        }
        public override void Run()
        {
            Console.WriteLine("Chay ca ngay");
        }
    }

}
