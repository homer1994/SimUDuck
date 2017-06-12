using System;

namespace SimUDuck
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new Behaviors.FlyNo();
            quackBehavior = new Behaviors.MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("It's a Decoy duck");
        }
    }
}
