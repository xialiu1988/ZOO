using System;
using System.Collections.Generic;
using System.Text;
using zoo.Interfaces;

namespace zoo.Classes
{
    public class Tiger : Mammal,Hunt
    {
        public override string color => "Tabby";

        public override int legs => 4;

       
        public override void Eat()
        {
            Console.WriteLine("I eat all kinds of Meat! I am not vegetarian.");
        }

        public string Hunt(Edible food)
        {
            return food.type;
        }

        public override void Sleep()
        {
            Console.WriteLine("I sleep on the ground.");
        }

        public string Speak(string name)
        {
           
            return name;
        }
    }
}
