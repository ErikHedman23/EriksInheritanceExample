using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Person //Base or Parent class
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }

        //method
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}!");
        }
    }
}
