using System;

using zoo.Classes;
using zoo.Interfaces;

namespace zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

//created a new object of Tiger ,Teddy is a Tiger
            Tiger tiger = new Tiger();
            
           string name=tiger.Speak("Ted");
            Console.WriteLine($"Hello,my name is {name}, i am a tiger");
            Console.WriteLine("My color is:"+ tiger.color);
            Console.WriteLine($"I have { tiger.legs} legs");
            tiger.Eat();
            tiger.Sleep();


            Console.WriteLine("**************");
            //created a panda object

            Panda panda = new Panda();
            panda.name = "Sunshine";
            Console.WriteLine($"Hi! I am a panda my name is {panda.name}");
            panda.Eat();
            panda.Sleep();

            Console.WriteLine("**************");
            //created a Monkey object
            Monkey monkey = new Monkey();
            monkey.name = "King";
            Console.WriteLine($"Hi! I am a monkey my name is {monkey.name}");
            monkey.Eat();
            monkey.Sleep();

            Console.WriteLine("**************");
            //created a Tutle object

            Turtle turtle = new Turtle();
            turtle.shell = 1;
            turtle.name = "Alex";
            Console.WriteLine($"Hi I am turtle,my name is {turtle.name} and i have {turtle.shell} shell");
            turtle.Eat();
            turtle.Move();
           Console.WriteLine( turtle.ControlBodyTemperature());
            turtle.Sleep();


            Console.WriteLine("**************");
            //created a Owl object

            Owl owl = new Owl();
            owl.Sleep();
            owl.Eat();
            owl.sound();
           Console.WriteLine("I can fly:"+ owl.fly());


            Console.WriteLine("**************");
            //created a Ostrich object

            Ostrich ostrich = new Ostrich();
            ostrich.Sleep();
            ostrich.Eat();
            Console.WriteLine("I can fly:" + ostrich.fly());
            Console.WriteLine("**************");
            Console.WriteLine("**************");
            string foodOne = tiger.Hunt(monkey);
            //string foodTwo=tiger.Hunt(ostrich);
            //Console.WriteLine($"I can hunt {foodOne} and {foodTwo}");
            Console.WriteLine($"I can hunt{foodOne}");
            Console.WriteLine("**************");
            Console.WriteLine(monkey.Mimic("jump and clap"));

        }
    }
}
