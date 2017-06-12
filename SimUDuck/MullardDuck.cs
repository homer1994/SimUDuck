using System;

namespace SimUDuck
{
    class MullardDuck : Duck
    {
        override public void Display()
        {
            //Mullard
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