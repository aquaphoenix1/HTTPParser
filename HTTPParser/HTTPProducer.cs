using System.Threading;

namespace HTTPParser
{
    class HTTPProducer
    {
        private readonly AbstractGetHTTP getHTTPStrategy;

        private const int SLEEP_TIME = 500;

        private readonly Thread thread;

        public bool Working { get; private set; }

        public HTTPProducer(AbstractGetHTTP getHTTPStrategy)
        {
            this.getHTTPStrategy = getHTTPStrategy;

            Working = true;

            thread = new Thread(Run);

            thread.Start();
        }

        internal void Stop()
        {
            thread.Abort();
        }

        private void Run()
        {
            while (true)
            {
                var linq = PCController.GetLink();

                if (linq != null)
                {
                    Working = true;

                    var result = getHTTPStrategy.GetHTTPPage(linq);

                    if (result != "")
                    {
                        PCController.AddNewTask(result);
                    }
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
