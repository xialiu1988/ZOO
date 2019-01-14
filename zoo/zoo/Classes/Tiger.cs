using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
    public class Tiger : Mammal
    {
        public override string color => "Tabby";

        public override int legs => 4;

       
        public override void Eat()
        {
            Console.WriteLine("I eat all kinds of Meat! I am not vegetarian.");
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
