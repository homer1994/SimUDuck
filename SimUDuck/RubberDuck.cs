using System;

namespace SimUDuck
{
    class RubberDuck : Duck
    {
        override public void Display()
        {
            //Rubber duck
        }

        override public void Fly()
        {
            new FlyNo().Fly();
        }

        override public void Quack()
        {
            //Override with Squeek
        }
    }
}
