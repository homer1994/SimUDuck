using System;

namespace SimUDuck
{
    public abstract class Duck
    {
        protected Behaviors.IFlyBehavior flyBehavior;
        protected Behaviors.IQuackBehavior quackBehavior;

        public void Swim()
        {
            Console.Write("Swim ducky, swim");
        }

        public void Quack()
        {
            quackBehavior.Quack();
        }

        abstract public void Display();

        public void Fly()
        {
            flyBehavior.Fly();
        }
    }
}