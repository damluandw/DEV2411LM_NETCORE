using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    internal interface ICalculator1
    {
        int Sum(int x, int y);
        int Mul(int x, int y);
    }
    internal interface ICalculator2
    {
        int Sub(int x, int y);
        int Div(int x, int y);
    }

    public class Calculator : ICalculator1, ICalculator2
    {
        public int Div(int x, int y)
        {
            return x / y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
