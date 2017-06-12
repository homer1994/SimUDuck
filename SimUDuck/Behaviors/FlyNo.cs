using System;

namespace SimUDuck.Behaviors
{
    public class FlyNo : IFlyBehavior
    {
        public void Fly()
        {
            Console.Write("Stay stationary");
        }
    }
}
