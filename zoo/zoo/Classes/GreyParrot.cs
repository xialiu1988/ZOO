using System;
using System.Collections.Generic;
using System.Text;
using zoo.Interfaces;

namespace zoo.Classes
{
    public class GreyParrot : Bird,Mimic
    {
        public override void Eat()
        {
            Console.WriteLine("I like sunflower seeds.");

        }
      public string Mimic(string movement)
        {
            return "I like mimic human talk!";
        }

        public override void Sleep()
        {
            Console.WriteLine("I like to bury my head when i sleep.");
        }
    }
}
