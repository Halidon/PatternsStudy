using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher.Widgets
{
    class TvWidget: IWidget
    {
        private string _tv;

        public void Update(string twitter, string lenta, string tv)
        {
            _tv = tv;      
        }

        public void Display() {
            Console.WriteLine("TV: {0}", _tv);
        }
    }
}
