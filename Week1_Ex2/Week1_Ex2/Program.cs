using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hs = new Hashtable();
            hs.Add(1, "HTML");
            hs.Add(2, "CSS");
            hs.Add(3, "Javascript");
            hs.Add(4, "Csharp");
            hs.Add(5, "Angular");
            hs.Add(6, "ReactJS");
            hs.Add(7, "SQL Server");

            if (hs.ContainsValue("HTML")) //kiem tra xem co ton tai phan tu khong 
            {
                Console.WriteLine("HTML is Hyper Text Markup Language in Hashtable");
            }
            else
            {
                Console.WriteLine("not in Hashtable");
            }
            foreach(DictionaryEntry item in hs) // xac dinh chinh xac kieu du lieu la DictionaryEntry
            {
                Console.WriteLine($"{item.Key} : {item.Value} ");
            }
            Console.ReadKey();
        }
    }
}
