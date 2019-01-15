using System;
using System.Collections.Generic;
using System.Text;
using zoo.Interfaces;

namespace zoo.Classes
{
    public class Monkey : Mammal,Edible,Mimic
    {
        public override string color => "Dark Brown";

        public override int legs => 4;

        public string type { get =>"Monkey"; set =>GetType(); }

        public override void Eat()
        {
            Console.WriteLine("Feed me feed me! i Want bananas!");
        }

        public override void Sleep()
        {
            Console.WriteLine("I can sleep on the tree!");

        }
        public override bool CanSwim()
        {
            return false;
        }
        public bool ClimbTree()
        {
            return true;
        }

        public void run()
        {
            Console.WriteLine("We run fast!");
        }

        public string Mimic(string movement)
        {
            return $"I can mimic {movement}, i am smart";
        }
    }
}
