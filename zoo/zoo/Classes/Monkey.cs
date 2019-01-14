using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
    public class Monkey : Mammal
    {
        public override string color => "Dark Brown";

        public override int legs => 4;

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
       
    }
}
