using System;
using Watcher.News;

namespace Watcher.Widgets
{
    class TwitterWidget: IObserver
    {
        private string _twitter;

        public TwitterWidget(ISubject observer)
        {
            observer.RegisterObserver(this);
        }

        public void Update(string twitter, string lenta, string tv)
        {
            _twitter = twitter;

            Display();
        }

        public void Display() {
            Console.WriteLine("Twitter: {0}", _twitter);
        }
    }
}
