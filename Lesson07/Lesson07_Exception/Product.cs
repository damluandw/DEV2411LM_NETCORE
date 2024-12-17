using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07_Exception
{
    internal class Product
    {
        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidPriceException("Giá phải lớn hơn 0");
                }
                else
                {
                    price = value;
                }
            }
        }
    }

    class InvalidPriceException : Exception
    {
        public InvalidPriceException(string msg) : base(msg) { }
    }
}
