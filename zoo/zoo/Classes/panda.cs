using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
    public class Panda : Mammal
    {
        public override string color => "Black and White";

        public override int legs => 4;

        public override void Eat()
        {
           Console.WriteLine("Most time i like bamboo they are not very delicious though");
        }

        public override void Sleep()
        {
            Console.WriteLine("I like sleeping oh the grass after i have meals");
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
