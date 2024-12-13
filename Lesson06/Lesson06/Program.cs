using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // ArrayList
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            //arrList.Add("devmaster");
            int[] arr = new int[8] { 8, 5, 6 ,555,66,222,4,45};
            arrList.AddRange(arr);
            Console.WriteLine("Chuỗi ArrayList");
            //Hiển thi
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine(arrList[i]);
            }
            Console.WriteLine("-------------------------------------");
            // sắp xếp - phải cùng kiểu dữ liệu
            arrList.Sort();
            Console.WriteLine("Chuỗi ArrayList sau khi sắp xếp");
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine(arrList[i]);
            }
            Console.WriteLine("-------------------------------------");
            //Xoá dữ liệu
            arrList.RemoveAt(0);
            Console.WriteLine("Chuỗi ArrayList sau khi xoá phần tử thứ nhất");
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine(arrList[i]);
            }
            //Remove theo value
            arrList.Remove(8);
            Console.WriteLine("Chuỗi ArrayList sau khi xoá mảng có giá trị là 8");
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine(arrList[i]);
            }

            arrList.RemoveRange(3,2);
            Console.WriteLine("Chuỗi ArrayList sau khi xoá từ vị trí số 4 đến 6");
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine(arrList[i]);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Chuỗi ArrayList trước khi clear:" + arrList.Count);
            arrList.Clear();
            Console.WriteLine("Chuỗi ArrayList sau khi clear:" + arrList.Count);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");
            //HashTable
            Hashtable hashtable = new Hashtable();
            hashtable.Add("HR", "Human Resoure");
            hashtable.Add("IT", "Information Technology");
            // Nếu hashtable đã có key là  MK thì gán  value là Makerting 
            // Ngược lại nếu hashtable chưa có key thì sẽ add thêm cặp key và value
            hashtable["MK"] = "Makerting";

            //hashtable["IT"] = "Makerting";
            //Hiển thị dữ liệu
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine("key:" + key +" \t value: "+ hashtable[key]);
            }
            // xoá dữ liệu - xoá theo key
            Console.WriteLine("-------------------------------------");
            //Remove theo key
            hashtable.Remove("IT");
            Console.WriteLine("Dữ liệu hashtable sau khi xoá key là IT");
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine("key:" + key + " \t value: " + hashtable[key]);
            }
            // Clear
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Dữ liệu hashtable trước khi clear:" + hashtable.Count);
            hashtable.Clear();
            Console.WriteLine("Dữ liệu hashtable sau khi clear:" + hashtable.Count);



            //SortedList
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");
            SortedList sortedList = new SortedList();
            sortedList.Add(3, "Human Resoure");
            sortedList.Add(2, "Information Technology");
            sortedList[4] = "Makerting";
            //Hiển thị dữ liệu
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("key:" + sortedList.GetKey(i) + " \t value: " + sortedList.GetByIndex(i));
            }
            Console.WriteLine("-------------------------------------");
            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine("key:" + key + " \t value: " + sortedList[key]);
            }
            // Xoá dữ liệu
            //Remove theo key
            sortedList.Remove(2);
            Console.WriteLine("sortedList sau khi xoá key 2");
            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine("key:" + key + " \t value: " + sortedList[key]);
            }
            //Remove theo vị trí
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("sortedList sau khi xoá vị trí 2");
            sortedList.RemoveAt(1);
            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine("key:" + key + " \t value: " + sortedList[key]);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("sortedList trước khi clear: "+ sortedList.Count);
            sortedList.Clear();
            Console.WriteLine("sortedList sau khi clear: " + sortedList.Count);

            ///tìm kiếm
            
            sortedList.ContainsKey(2);// tìm kiếm theo key
            sortedList.ContainsValue("Makerting");// tìm kiếm theo value
            arrList.Contains(3);// tìm kiếm 
            hashtable.ContainsValue("Makerting");// tìm kiếm theo value
            hashtable.ContainsKey("HR");// tìm kiếm theo key
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");
            //Generic Collection - các kiểu dữ liệu sẽ phải xác định ngay từ đầu
            //List, Dictionary, SortedList
            //ArrayList có các phương thức nào thì List có các phương thức đó
            //Hashtable có các phương thức nào thì Dictionary có các phương thức đó
            //SortedList có các phương thức nào thì SortedList có các phương thức đó
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.AddRange(arr);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-------------------------------------");
            List<string> chuoi = new List<string>()
            {
                "Devmaster","Vũ Ngọc Phan","Hà Nội"
            };

           for (int i = 0; i < chuoi.Count; i++)
            {
                Console.WriteLine(chuoi[i]);
            }
            Console.WriteLine("-------------------------------------");
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "một");
            dict.Add(2, "hai");
            dict.Add(3, "ba");
            foreach (var key in dict.Keys)
            {
                Console.WriteLine("key:" + key + " \t value: " + dict[key]);
            }

            Console.WriteLine("-------------------------------------");
            Dictionary<int, string> dict2 = new Dictionary<int, string>()
            {
                {1, "một" },
                {2, "hai" },
                {3, "ba" }
            };
            foreach (var key in dict2.Keys)
            {
                Console.WriteLine("key:" + key + " \t value: " + dict2[key]);
            }
        }
    }
}
