using Strategy.Fly;
using Strategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    public class UpgradableDuck: DuckBase
    {
        public UpgradableDuck() {
            quackBegaviour = new NoQuack();
            flyBehaviour = new NoFly();
        }
        public override void Display()
        {
            Console.WriteLine("I'm an upgradable duck");
        }
    }
}
