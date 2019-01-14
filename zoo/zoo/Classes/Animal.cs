using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
public abstract class Animal
    {
        public virtual string name  { get; set; }
       public abstract void Eat();
       public abstract void Sleep();


    }
}
