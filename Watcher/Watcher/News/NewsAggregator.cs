using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watcher.Widgets;

namespace Watcher.News
{
    class NewsAggregator
    {
        private static TwitterWidget _twitterWidget;
        private static LentaWidget _lentaWidget;
        private static TvWidget _tvWidget;
        private static Random _random;

        public NewsAggregator() {
            _twitterWidget = new TwitterWidget();
            _lentaWidget = new LentaWidget();
            _tvWidget = new TvWidget();
            _random = new Random();
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

        public void NewNewsAvailable() {
            string twitter = GetTwitterNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            _twitterWidget.Update(twitter, lenta, tv);
            _lentaWidget.Update(twitter, lenta, tv);
            _tvWidget.Update(twitter, lenta, tv);
        }
    }
}
