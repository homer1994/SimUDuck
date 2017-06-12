using System;

namespace SimUDuck
{
    class MullardDuck : Duck, IDuck
    {
        public void Display()
        {
            //Mullard
        }

        public void Fly()
        {
            FlyingDuck.Fly();
        }

        public void Quack()
        {
            throw new NotImplementedException();
        }
    }
}