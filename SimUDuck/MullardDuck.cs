namespace SimUDuck
{
    public class MullardDuck : Duck
    {
        public MullardDuck()
        {
            flyBehavior = new Behaviors.FlyWithWings();
            quackBehavior = new Behaviors.QuackNormal();
        }

        override public void Display()
        {
            //Mullard
        }
    }
}