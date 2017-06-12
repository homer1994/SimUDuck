using System;

namespace SimUDuck
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new Behaviors.FlyWithWings();
            quackBehavior = new Behaviors.QuackNormal();
        }

        override public void Display()
        {
            Console.Write("It's a Redhead duck");
        }
    }
}
