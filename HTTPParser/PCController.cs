using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace HTTPParser
{
    public static class PCController
    {
        private static MainForm mainForm;

        private static BlockingCollection<string> taskCollection;

        private static List<HTTPConsumer> httpConsumers;

        private static volatile IParser parserStrategy = new Parser();

        private static List<HTTPProducer> httpProducers;

        private static readonly AbstractGetHTTP getHTTPStrategy = new GetHTTP();

        private static BlockingCollection<string> linqCollection;

        private static readonly List<string> checkedLinqs = new List<string>();

        private const int CHECK_TIMER_TIME_UPDATE = 5000;

        private static Timer checkTimer;

        internal static void Init(MainForm mainForm, int producersCount, int consumersCount)
        {
            PCController.mainForm = mainForm;

            httpProducers = new List<HTTPProducer>(producersCount);
            httpConsumers = new List<HTTPConsumer>(consumersCount);

            taskCollection = new BlockingCollection<string>();
            linqCollection = new BlockingCollection<string>();

            Run(producersCount, consumersCount);

            checkTimer = new Timer(CHECK_TIMER_TIME_UPDATE)
            {
                AutoReset = true
            };
            checkTimer.Elapsed += CheckAll;

            checkTimer.Start();
        }

        private static void CheckAll(object sender, ElapsedEventArgs e)
        {
            bool isConsumersWorking = httpConsumers.Any(x => x.Working);
            bool isProducersWorking = httpProducers.Any(x => x.Working);

            if(!isProducersWorking && !isConsumersWorking)
            {
                checkTimer.Elapsed -= CheckAll;

                mainForm.StopClicked();
            }
        }

        internal static int GetCountProducersTask()
        {
            return linqCollection.Count;
        }

        internal static int GetCountConsumersTask()
        {
            return taskCollection.Count;
        }

        internal static bool IsInit()
        {
            return mainForm != null;
        }

        internal static void ShutDown()
        {
            checkTimer.Stop();
            checkTimer.Dispose();

            httpProducers.ForEach(x => x.Stop());
            httpConsumers.ForEach(x => x.Stop());

            mainForm = null;

            checkedLinqs.Clear();
            taskCollection.Dispose();
            httpConsumers.Clear();
            httpProducers.Clear();
            linqCollection.Dispose();
        }

        internal static void AddIfValideHTTP(string value)
        {
            if (!checkedLinqs.Contains(value))
            {
                checkedLinqs.Add(value);

                linqCollection.Add(value);

                mainForm.AddLinq(value);
            }
        }

        public static string GetLink()
        {
            linqCollection.TryTake(out string linq);

            return linq;
        }

        public static void AddLink(string linq)
        {
            linqCollection.Add(linq);
        }

        public static void AddNewTask(string task)
        {
            taskCollection.Add(task);
        }

        public static string GetTask()
        {
            taskCollection.TryTake(out string task);

            return task;
        }

        public static void ChangeParserStrategy(IParser parser)
        {
            parserStrategy = parser;

            httpConsumers.ForEach(x => x.ChangeParserStrategy(parser));
        }

        private static void Run(int producersCount, int consumersCount)
        {
            for (int i = 0; i < producersCount; i++)
            {
                httpProducers.Add(new HTTPProducer(getHTTPStrategy));
            }

            for (int i = 0; i < consumersCount; i++)
            {
                httpConsumers.Add(new HTTPConsumer(parserStrategy));
            }
        }

        internal static void AddConsumer()
        {
            httpConsumers.Add(new HTTPConsumer(parserStrategy));
        }

        internal static void AddProducer()
        {
            httpProducers.Add(new HTTPProducer(getHTTPStrategy));
        }
    }
}
