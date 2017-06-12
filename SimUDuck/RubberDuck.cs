using System;

namespace SimUDuck
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new Behaviors.FlyNo();
            quackBehavior = new Behaviors.Squeak();
        }

        override public void Display()
        {
            Console.Write("It's a Rubber duck");
        }
    }
}
