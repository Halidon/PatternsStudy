using Strategy.Quack;
using System;

namespace Strategy.Ducks
{
    class ExoticDuck : DuckBase
    {
        public ExoticDuck() {
            quackBegaviour = new ExoticQuack();          
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm exotic duck!");
        }     
    }
}
