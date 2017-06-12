using System;

namespace SimUDuck
{
    public class RedheadDuck : Duck
    {
        override public void Display()
        {
            //Redhead
        }

        override public void Fly()
        {
            new FlyWithWings().Fly();
        }

        override public void Quack()
        {
            throw new NotImplementedException();
        }
    }
}
