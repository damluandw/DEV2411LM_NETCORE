using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{

    /// <summary>
    /// khai báo class sealed không cho kế thừa
    /// </summary>
    sealed class Product
    {
        string id;
        string name;
        string description;
        float price;
        public Product(string id, string name, string description, float price)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
    // biên dịch sẽ báo lỗi
    //class Pen : Product
    //{
    //    public Pen(string id, string name, string description, float price):base(id,name, description,price)
    //    {
           
    //    }

    //}
}
