using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksContacts
{
    public class Person
    {
        private string name = "";
        private string number = "";

        public Person(string name, string number)
        {
            this.name = name;
            this.number = number;
        }

        public void printName()
        {
            Console.WriteLine("Name: " + this.name);
        }
    }
}
