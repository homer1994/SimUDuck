using System;

namespace SimUDuck
{
    public class RedheadDuck : Duck, IDuck
    {
        public void Display()
        {
            //Redhead
        }

        public void Fly()
        {
            new FlyWithWings().Fly();
        }

        public void Quack()
        {
            throw new NotImplementedException();
        }
    }
}
