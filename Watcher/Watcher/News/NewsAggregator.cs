using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watcher.Widgets;

namespace Watcher.News
{
    class NewsAggregator : ISubject
    {
        private static Random _random;
        private List<IObserver> _observers;

        public NewsAggregator() {
            _random = new Random();
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
         
        public void NotifyObservers()
        {
            string twitter = GetTwitterNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            foreach (var observer in _observers) {
                observer.Update(twitter, lenta, tv);
            }
        }


        public string GetTwitterNews() {
            var news = new List<string> {
                "Twitter new 1",
                 "Twitter new 2",
                  "Twitter new 3"
            };

            return news[_random.Next(3)];
        }

        public string GetLentaNews()
        {
            var news = new List<string> {
                "Lenta new 1",
                 "Lenta new 2",
                  "Lenta new 3"
            };

            return news[_random.Next(3)];
        }

        public string GetTvNews()
        {
            var news = new List<string> {
                "Tv new 1",
                 "Tv new 2",
                  "Tv new 3"
            };

            return news[_random.Next(3)];
        }
    }
}
