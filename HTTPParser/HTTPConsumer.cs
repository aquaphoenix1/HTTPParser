using System.Threading;

namespace HTTPParser
{
    class HTTPConsumer
    {
        private volatile IParser parserStrategy;

        private const int SLEEP_TIME = 500;

        private readonly Thread thread;

        public bool Working { get; private set; }

        public HTTPConsumer(IParser parserStrategy)
        {
            this.parserStrategy = parserStrategy;

            Working = true;

            thread = new Thread(Start);

            thread.Start();
        }

        internal void ChangeParserStrategy(IParser parser)
        {
            parserStrategy = parser;
        }

        internal void Stop()
        {
            thread.Abort();
        }

        private void Start()
        {
            while (true)
            {
                var task = PCController.GetTask();

                if (task != null)
                {
                    Working = true;

                    parserStrategy.Parse(task);
                }
                else
                {
                    Working = false;

                    Thread.Sleep(SLEEP_TIME);
                }
            }
        }
    }
}
