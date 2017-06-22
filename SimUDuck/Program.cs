using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MullardDuck");
            Duck mallard = new MullardDuck();
            mallard.Quack();
            mallard.Fly();

            Console.WriteLine();
            Console.WriteLine("RubberDuck");
            Duck rubberDuck = new RubberDuck();
            rubberDuck.Quack();

            rubberDuck.setQuackBehavior(new Behaviors.MuteQuack());
            rubberDuck.Quack();

            Console.WriteLine();
            Console.WriteLine("DecoyDuck");
            Duck decoyDuck = new DecoyDuck();
            decoyDuck.Swim();
        }
    }
}