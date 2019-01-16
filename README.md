# ZOO

Description:



The very first layer class is Animal, and it has three direct derived classes: Mammal, Reptile, Bird. These are  all abstract classes.


There are 7 types of Animals in this lab: Tiger, Monkey, Panda, Turtle, Owl, Ostrich. These are concrete classes and when they inherit base class

they need to implement all abstract methods in theri abstract base classes.
 
Different classes can display different methods based on OOP's polymorphism, for example, Eat() and Sleep() output differnt things

in Tiger and Monkey classes


![tiger](tiger.png)




![monkey](monkey.png)




Monkey has one derived class called HowlerMonkey. And HowlerMonkey has all base class Monkey's properties and methods.

# Interfaces
And in the zoo, there are three Interfaces: Edible(for Ostrich and Monkey), Hunt(for Tiger and Owl), Mimic(for Monkey and GreyParrot).


So when you do : string foodOne = tiger.Hunt(monkey); 
                 Console.WriteLine($"I can hunt{foodOne}");
				 
				 it will output :

![hunt](tigerHunt.png)



when you do  :   Console.WriteLine(monkey.Mimic("jump and clap"));  
   

The ouptput will be this:

              
![mimic](mimic.png)



 



 The whole zoo diagram is like this:


![draw](newzoo2.png)