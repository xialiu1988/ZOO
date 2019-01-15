using System;
using System.Collections.Generic;
using System.Text;
using zoo.Interfaces;

namespace zoo.Classes
{
    public class Ostrich : Bird,Edible

    {
        public string type { get => "Ostrich"; set => GetType(); }

        public override void Eat()
        {
            Console.WriteLine("I like vegetables, i eat grass");
        }

        public override void Sleep()
        {
            Console.WriteLine("I stay still, but my eyes are open and neck upright.");
        }
        public bool BuryHead()
        {
            return true;
        }
        public override bool fly()
        {
            return false;
        }

        public void run()
        {
            Console.WriteLine("I am fat but i run quick!");
        }
    }
}
