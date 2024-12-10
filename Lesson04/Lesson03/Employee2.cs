using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    internal class Employee2
    {
        public string name;
        protected decimal basepay;
        public Employee2(string name, decimal basepay) { 
            this.name = name;
            this.basepay = basepay;
        }

        /// <summary>
        /// Khai báo phương thức có thể ghi đè
        /// </summary>
        /// <returns></returns>
        public virtual decimal CalPay()
        {
            return basepay;
        }
    }
    internal class SalaryEmployee2:Employee2
    {
        private decimal saleBonus;
        public SalaryEmployee2 (string name, decimal basepay, decimal saleBonus):base(name, basepay) { 
            this.saleBonus = saleBonus;
        }
        /// <summary>
        /// Khai báo phương thức ghi đè
        /// </summary>
        /// <returns></returns>
        public override decimal CalPay()
        {
            return basepay +saleBonus;
        }
    }
}
