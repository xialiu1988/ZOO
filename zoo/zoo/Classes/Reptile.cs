using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
    public abstract class Reptile:Animal
    {
        public virtual int tail {get;set;}
        public virtual int legs { get; set; }

        public override void Sleep()
        {
            Console.WriteLine("I need to sleep in both Winter and Summer");
        }

        public bool CanSwim() { return true; }

        public void Move()
        {
            Console.WriteLine("I  have to crawl using the help of limbs and tail.");
        }

       
        public bool ControlBodyTemperature()
        {
            return false;
        }

    }
}
