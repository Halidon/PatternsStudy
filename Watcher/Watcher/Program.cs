﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watcher.News;

namespace Watcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAgregator = new NewsAggregator();

            newsAgregator.NewNewsAvailable();
            Console.WriteLine();
            newsAgregator.NewNewsAvailable();
            Console.ReadKey();
        }

        public static void Test() {
            Console.WriteLine("Hello world");
        }

        public static void Test2() {

        }
    }
}
