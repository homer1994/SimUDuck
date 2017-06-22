using System;

namespace SimUDuck.Behaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly like a rocket");
        }
    }
}
