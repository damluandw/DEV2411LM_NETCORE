using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; private set; } //chỉ đọc

        public string Price { private get;  set; } //chỉ ghi
    }
}
