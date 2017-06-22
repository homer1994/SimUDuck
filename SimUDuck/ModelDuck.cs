using System;

namespace SimUDuck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new Behaviors.FlyNo();
            quackBehavior = new Behaviors.QuackNormal();
        }

        public override void Display()
        {
            Console.WriteLine("It's a model duck");
        }
    }
}
