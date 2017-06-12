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
            new Behaviors.FlyNo().Fly();
        }

        override public void Quack()
        {
            //Override with Squeek
        }
    }
}
