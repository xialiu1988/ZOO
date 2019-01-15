using System;
using System.Collections.Generic;
using System.Text;
using zoo.Interfaces;

namespace zoo.Classes
{
    public class Turtle : Reptile,Edible
    {
        public int shell { get; set; }
        public string type { get => "Turtle"; set => GetType(); }

        public override void Eat()
        {
            Console.WriteLine("I eat water lettuce, and water hyacinth");
        }

        public bool HideHeadInShell()
        {
            return true;
        }

        public void run()
        {
            Console.WriteLine("I can't run,i crawl.....");
        }
    }
}
