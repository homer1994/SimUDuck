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
            throw new NotImplementedException();
        }

        public void Quack()
        {
            //Override with Squeek
        }
    }
}
