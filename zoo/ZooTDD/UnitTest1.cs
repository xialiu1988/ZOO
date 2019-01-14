using System;
using Xunit;
using zoo;
using zoo.Classes;

namespace ZooTDD
{
    public class UnitTest1
    {
       

        [Fact]
        public void TigerCanSpeakitsName()
        {
            Tiger tiger = new Tiger();
            string name = "Teddy";
            Assert.Equal(name, tiger.Speak(name));
        }


        [Fact]
        public void TigerCanGiveLiveBirth()
        {
            Tiger tiger = new Tiger();
            Assert.True(tiger.GiveLiveBirth());
        }

        [Fact]
        public void MonkeyCanClimbTree()
        {
            Monkey monkey = new Monkey();
            Assert.True(monkey.ClimbTree());
        }

        [Fact]
        public void MonkeyCanNotSwim()
        {
            Monkey monkey = new Monkey();
            Assert.False(monkey.CanSwim());
        }



        [Fact]
        public void PandaCanNotSwim()
        {
            Panda panda = new Panda();
            Assert.False(panda.CanSwim());
        }
        [Fact]
        public void PandaCanClimb()
        {
            Panda panda = new Panda();
            Assert.True(panda.ClimbTree());
        }

        [Fact]
        public void TurtleCanNotControlBodyTemp()
        {
            Turtle turtle = new Turtle();
            Assert.False(turtle.ControlBodyTemperature());
        }


        [Fact]
        public void TurtleCanHideinShell()
        {
            Turtle turtle = new Turtle();
            Assert.True(turtle.HideHeadInShell());
        }

        [Fact]
        public void OwlCanFly()
        {
            Owl owl = new Owl();
            Assert.True(owl.fly());
        }

        [Fact]
        public void OwlCanmakeSound()
        {
            Owl owl = new Owl();
            string expected="tur tur tur";
            Assert.Equal(expected,owl.sound());
        }


        [Fact]
        public void OstrichCannotFly()
        {
            Ostrich ostrich = new Ostrich();
            Assert.False(ostrich.fly());
        }


        [Fact]
        public void OstrichCanBuryHed()
        {
            Ostrich ostrich = new Ostrich();
            Assert.True(ostrich.BuryHead());
        }

        [Fact]
        public void HowlerMOnkeyscanHowl()
        {
            HowlerMonkeys howler= new HowlerMonkeys();
            Assert.True(howler.Howling());
        }

        [Fact]
        public void HowlerMOnkeyscanClimbTree()
        {
            HowlerMonkeys howler = new HowlerMonkeys();
            Assert.True(howler.ClimbTree());
        }


    }
}
