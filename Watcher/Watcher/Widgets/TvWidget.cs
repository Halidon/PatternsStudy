using System;
using Watcher.News;

namespace Watcher.Widgets
{
    class TvWidget: IObserver
    {
        private string _tv;

        public TvWidget(ISubject observer) {
            observer.RegisterObserver(this);
        }


        public void Update(string twitter, string lenta, string tv)
        {
            _tv = tv;
            Display();
        }

        public void Display() {
            Console.WriteLine("TV: {0}", _tv); 
        }
    }
}
