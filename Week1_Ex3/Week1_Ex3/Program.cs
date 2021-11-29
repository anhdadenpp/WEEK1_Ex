using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\students.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                } 
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.ReadLine();
        }
    }
}
