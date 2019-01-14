using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
    public class Ostrich : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("I like vegetables, i eat grass");
        }

        public override void Sleep()
        {
            Console.WriteLine("I stay still, but my eyes are open and neck upright.");
        }

        public override bool fly()
        {
            return false;
        }
        

    }
}
