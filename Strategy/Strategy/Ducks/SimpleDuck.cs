using System;

namespace Strategy.Ducks
{
    class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hi! I'm simple duck");
        }
    }
}
