using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex3
{
    internal class student
    {
        private int id;
        private string name;
        private string room;

        public student() { }

        public student(int id, string name, string room)
        {
            this.Id = id;
            this.Name = name;
            this.Room = room;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Room { get => room; set => room = value; }
    }
}
