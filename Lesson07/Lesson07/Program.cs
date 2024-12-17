using Electronic.Sony;
using samsung = Electronic.Samsung;

//using Electronic;
//using  Electronic.Samsung;
using System.Collections;
using System.Collections.Generic;
namespace Lesson07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Review
            ////Collection
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1); // add 1 giá trị
            //int[] numbers = { 1, 2, 3, 4 }; 
            //arrayList.AddRange(numbers); //add nhiều giá trị
            //arrayList.Sort(); // phương thức sắp xếp
            //arrayList.Remove(1);//remove theo value
            //arrayList.RemoveAt(0);//remove theo vị trí
            //arrayList.RemoveRange(0, 2);//remove từ vị trí đến vị trí nào
            //arrayList.Reverse();//đảo
            //arrayList.Contains(1); // so sánh giá trị
            //arrayList.Clear();
            //for(int i =0; i< arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, 2);
            //hashtable.Add(2, 3);
            //hashtable[4] = 4;
            //hashtable[5] = 5;
            //hashtable.Remove(4);//remove theo key
            //hashtable.Contains(5);
            //hashtable.ContainsKey(5); 
            //hashtable.ContainsValue(5);
            //hashtable.Clear();
            //foreach(int key in hashtable.Keys)
            //{
            //    Console.WriteLine(key + " - " + hashtable[key]);
            //}

            //SortedList sortedList = new SortedList();
            //sortedList.Add(1, 2);
            //sortedList.Add(2, 3);
            //sortedList[4] = 4;
            //sortedList[5] = 5;
            //sortedList.Remove(4);//remove theo key
            //sortedList.Contains(5);
            //sortedList.ContainsKey(5);
            //sortedList.ContainsValue(5);
            //sortedList.Clear();
            //for (int i = 0; i < sortedList.Count; i++)
            //{
            //    Console.WriteLine(sortedList.GetKey(i) + " - " + sortedList.GetByIndex(i));
            //}
            //foreach (int key in sortedList.Keys)
            //{
            //    Console.WriteLine(key + " - " + sortedList[key]);
            //}
            ////Generic Collection
            //List<int> list = new List<int>();
            //Dictionary<int,string> dicionary = new Dictionary<int,string>();
            //SortedList<string, int> sortedList2 = new SortedList<string, int>();

            //Sử dụng namespace
            //Cách 1: sử dụng using tên_namespace; bên ngoài namespace sử dụng đến nó
            XperiaZ XperiaZ = new XperiaZ();
            //Cách 2: sử dụng tên_namespace.tên_class : trỏ tường mình
            Electronic.Tivi tivi = new Electronic.Tivi();

            //Cách 3: sử dụng tên alias -bí danh
            // đặt tên alias cho namespace -> alias.tên_class
            samsung.GalaxyA galaxyA = new samsung.GalaxyA();
            samsung.GalaxyS galaxyS = new samsung.GalaxyS();
            samsung.MayGiat mayGiat = new samsung.MayGiat();
            //Electronic.Samsung.Tivi tivi1 = new Electronic.Samsung.Tivi();

            //samsung.Tivi tiviSamsung = new samsung.Tivi();
            //Tivi tivi1 = new Tivi();


            
        }
    }
}
