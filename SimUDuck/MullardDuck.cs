using System;

namespace SimUDuck
{
    public class MullardDuck : Duck
    {
        public MullardDuck()
        {
            flyBehavior = new Behaviors.FlyWithWings();
            quackBehavior = new Behaviors.QuackNormal();
        }

        override public void Display()
        {
            Console.Write("It's a mallard");
        }
    }
}