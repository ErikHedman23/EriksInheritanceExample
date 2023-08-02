using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Sport : Person //You could make Bill also a coder and a person by changing person to coder because coder is a person
    {
        public string Sporting { get; set;}
        public void PlayGame ()
        {
            Console.WriteLine($"I can play {Sporting}");

        }
    }
}
