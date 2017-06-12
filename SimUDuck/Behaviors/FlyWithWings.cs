using System;

namespace SimUDuck.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
}
