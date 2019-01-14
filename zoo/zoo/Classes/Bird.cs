using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
   public abstract class Bird:Animal
    {
        public virtual string sound()
        {
          return "tur tur tur";
        }
        public virtual bool fly(){

            return true;
        }
    }
}
