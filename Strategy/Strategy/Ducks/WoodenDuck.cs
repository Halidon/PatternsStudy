﻿using Strategy.Fly;
using Strategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    public class WoodenDuck : DuckBase
    {
        public WoodenDuck() {
            flyBehaviour = new NoFly();
            quackBegaviour = new NoQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm a wooden duck");
        }        
    }
}
