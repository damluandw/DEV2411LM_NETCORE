using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    
    internal class Overview
    {
        /*
         * 1. Lớp trừu tượng: abstract
         * - phương thức trừu tượng: abstract
         * - phương thức không trừu tượng : không có abstract
         * - để kế thừa phương thức trừu tượng: override
         * 2. Lớp giao diện: Interface
         * - phương thức trừu tượng: phương thức k chứa nội thực thi
         * - kế thừa phương thức trừu tượng thì k dùng từ khoá override
         * - khi kế thừa interface thì phải có thực thi tất cả các phương thức của interface
         * - các phương thức chỉ thực thi ở class kế thừa
         * - đa kế thừa -> class sẽ phải thực thi tất cả các phương thức trong các interface khác nhau
         * => Thực thi phương thức trừu tượng tại class
         * 3. Mảng
         * - Mảng 1 chiều
         *      kiểu_dữ_liệu[] tên_mảng = kiểu_dữ_liệu[]{....}
         * 
         * - Mảng 2 chiều 
         *  + Mảng 2 chiều hình chữ nhật
         *          kiểu_dữ_liệu[,] tên_mảng = new kiểu_dữ_liệu[số_dòng,số_côt] 
         *          {
         *              {....}
         *              ...
         *              {....}
         *          }
         *  + Mảng 2 chiều ziczac
         *          kiểu_dữ_liệu[][] tên_mảng = new kiểu_dữ_liệu[số_dòng][]
         *          tên_mảng[dòng] = {...}
         * -  Array nằm trong namespace System
         *  + Sort
         *  + Reverse
         *  + Indexof
         *  + LastIndexof
         *  + Resize
         */
    }
}
