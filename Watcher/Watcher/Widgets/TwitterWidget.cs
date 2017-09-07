using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher.Widgets
{
    class TwitterWidget: IWidget
    {
        private string _twitter;

        public void Update(string twitter, string lenta, string tv)
        {
            _twitter = twitter;
        }

        public void Display() {
            Console.WriteLine("Twitter: {0}", _twitter);
        }
    }
}
