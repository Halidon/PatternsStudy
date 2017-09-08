using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watcher.News;
using Watcher.Widgets;

namespace Watcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAgregator = new NewsAggregator();

            var twitterWidjet = new TwitterWidget(newsAgregator);
            var lentaWidget = new LentaWidget(newsAgregator);
            var tvWidjet = new TvWidget(newsAgregator); 

            newsAgregator.NotifyObservers();
            Console.WriteLine();
            newsAgregator.NotifyObservers();
            Console.ReadKey();
        } 
    }
}
