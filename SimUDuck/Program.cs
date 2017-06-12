using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MullardDuck();
            mallard.Fly();
            Duck rubberDuck = new RubberDuck();
            rubberDuck.Quack();
        }
    }
}