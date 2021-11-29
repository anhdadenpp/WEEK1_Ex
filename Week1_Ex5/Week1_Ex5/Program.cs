using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cat cat = new cat();
            dog dog = new dog();
            cat.sound();
            dog.sound();
            Console.ReadKey();
        }
    }
}
