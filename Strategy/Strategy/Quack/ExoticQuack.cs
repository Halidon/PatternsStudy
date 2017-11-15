using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Quack
{
    class ExoticQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Exotic Quack");
        }
    }
}
