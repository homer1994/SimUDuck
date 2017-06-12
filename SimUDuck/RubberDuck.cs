using System;

namespace SimUDuck
{
    class RubberDuck : Duck, IDuck
    {
        public void Display()
        {
            //Rubber duck
        }

        public void Fly()
        {
            new FlyNo().Fly();
        }

        public void Quack()
        {
            //Override with Squeek
        }
    }
}
