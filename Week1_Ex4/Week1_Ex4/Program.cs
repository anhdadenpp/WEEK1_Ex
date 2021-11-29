using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            Dog d = new Dog();
            c.animalSound();
            d.animalSound();
            Console.ReadKey();
        }
    }
}
