using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    internal interface ITerrestrialAnimal {
        void Eat();
  
    }
    internal interface IMarineAnimal
    {
        void Eat();

    }

    public class Crocodie : ITerrestrialAnimal, IMarineAnimal
    {
        // thực thi tường minh 2 phương thức của giao diện
        void ITerrestrialAnimal.Eat()
        {
            Console.WriteLine("ITerrestrialAnimal eat");
        }
        void IMarineAnimal.Eat()
        {
            Console.WriteLine("IMarineAnimal eat");
        }

        // public các phương thức ra ngoài khi cần sử dụng
        public void TerrestrialAnimalEat()
        {
            ITerrestrialAnimal ta = this;
            ta.Eat();
        }
        public void MarineAnimalEat()
        {
            IMarineAnimal ma = this;
            ma.Eat();
        }
    }
}
