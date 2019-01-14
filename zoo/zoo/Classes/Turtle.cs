using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
    public class Turtle : Reptile
    {
        public int shell { get; set; }
        public override void Eat()
        {
            Console.WriteLine("I eat water lettuce, and water hyacinth");
        }

        public bool HideHeadInShell()
        {
            return true;
        }

    }
}
