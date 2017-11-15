using Strategy.Fly;
using Strategy.Quack;
using System;

namespace Strategy.Ducks
{
    public abstract class DuckBase
    {
        protected IFlyable flyBehaviour;
        protected IQuackable quackBegaviour;

        public DuckBase() {
            flyBehaviour = new FlyWithWings();
            quackBegaviour = new SimpleQuack();
        }

        public void setQuackBehaviour(IQuackable QuackBehaviour) {
            quackBegaviour = QuackBehaviour;
        }

        public void setFlyBehaviour(IFlyable FlyBehaviour) {
            flyBehaviour = FlyBehaviour;
        }
   
        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }
        public virtual void Quack()
        {
            quackBegaviour.Quack();
        }

        public virtual void Fly()
        {
            flyBehaviour.Fly();
        }

        public abstract void Display();
    }
}
