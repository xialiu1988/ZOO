using System;
using System.Collections.Generic;
using System.Text;
using zoo.Interfaces;

namespace zoo.Classes
{
    public class Owl : Bird,Hunt
    {
        public override void Eat()
        {
            Console.WriteLine("I like mice and insects mostly");
        }

        public string Hunt(Edible food)
        {
            return food.type;
        }

        public override void Sleep()
        {
            Console.WriteLine("I sleep in the daytime.");
        }
    }
}
