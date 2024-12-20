using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    
        public Person(string _Name,int _Age)
        {
                Name = _Name;
                Age = _Age;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
