using System;

namespace SimUDuck.Behaviors
{
    public class QuackNormal : IQuackBehavior
    {
        public void Quack()
        {
            Console.Write("Quack");
        }
    }
}
