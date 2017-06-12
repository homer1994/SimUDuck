using System;

namespace SimUDuck.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Silence");
        }
    }
}
