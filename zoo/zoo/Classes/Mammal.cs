using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
public abstract class Mammal : Animal
    {
        public abstract string color { get; }
        public abstract int legs {get;}
        public virtual bool CanSwim()
        {
            return true;
        }
      public bool GiveLiveBirth()
        {
            return true;
        }
    }
}
