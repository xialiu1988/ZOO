using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
    public class Owl : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("I like mice and insects mostly");
        }

        public override void Sleep()
        {
            Console.WriteLine("I sleep in the daytime.");
        }
    }
}
