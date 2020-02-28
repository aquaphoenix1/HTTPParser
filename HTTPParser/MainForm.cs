using System;
using System.Collections.Concurrent;
using System.Timers;
using System.Windows.Forms;

namespace HTTPParser
{
    public partial class MainForm : Form
    {
        private const int UPDATE_PRINT_TIMER_TIME = 1000;
        private const int UPDATE_TASKS_COUNT_TIMER_TIME = 1000;
        private readonly System.Timers.Timer printTimer;
        private readonly System.Timers.Timer tasksPrintCountTimer;
        private readonly BlockingCollection<string> printURLsCollection;

        public MainForm()
        {
            InitializeComponent();

            printTimer = new System.Timers.Timer(UPDATE_PRINT_TIMER_TIME)
            {
                AutoReset = true
            };

            printTimer.Elapsed += PrintURLs;

            tasksPrintCountTimer = new System.Timers.Timer(UPDATE_TASKS_COUNT_TIMER_TIME)
            {
                AutoReset = true
            };

            tasksPrintCountTimer.Elapsed += PrintCountTasks;

            printURLsCollection = new BlockingCollection<string>();
        }

        private void PrintCountTasks(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (sender == null)
                {
                    textBoxCurrentConsumersTasks.Invoke((MethodInvoker)(delegate () { textBoxCurrentConsumersTasks.Text = "0"; }));
                    textBoxCurrentProducersTask.Invoke((MethodInvoker)(delegate () { textBoxCurrentProducersTask.Text = "0"; }));
                }
                else
                {
                    textBoxCurrentConsumersTasks.Invoke((MethodInvoker)(delegate () { textBoxCurrentConsumersTasks.Text = PCController.GetCountConsumersTask().ToString(); }));
                    textBoxCurrentProducersTask.Invoke((MethodInvoker)(delegate () { textBoxCurrentProducersTask.Text = PCController.GetCountProducersTask().ToString(); }));
                }
            }
            catch { }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (PCController.IsInit())
            {
                StopClicked();
            }
            else
            {
                richTextBoxLinqs.Clear();
                numericUpDownCount.Value = 0;

                PCController.Init(this, (int)numericUpDownProducersCount.Value, (int)numericUpDownConsumersCount.Value);

                PCController.AddLink(textBoxStartLinq.Text);

                buttonStart.Text = "Стоп";

                buttonAddConsumer.Enabled = true;
                buttonAddProducer.Enabled = true;

                textBoxCurrentProducersCount.Text = numericUpDownProducersCount.Value.ToString();
                textBoxCurrentConsumersCount.Text = numericUpDownConsumersCount.Value.ToString();

                if ((int)numericUpDownProducersCount.Value == 10)
                {
                    buttonAddProducer.Enabled = false;
                }

                if ((int)numericUpDownConsumersCount.Value == 10)
                {
                    buttonAddConsumer.Enabled = false;
                }

                printTimer.Start();
                tasksPrintCountTimer.Start();
            }
        }

        public void StopClicked()
        {
            buttonStart.Invoke((MethodInvoker)(delegate () { buttonStart.Text = "Старт"; }));
            buttonAddConsumer.Invoke((MethodInvoker)(delegate () { buttonAddConsumer.Enabled = false; }));
            buttonAddProducer.Invoke((MethodInvoker)(delegate () { buttonAddProducer.Enabled = false; }));
            textBoxCurrentProducersCount.Invoke((MethodInvoker)(delegate () { textBoxCurrentProducersCount.Text = "0"; }));
            textBoxCurrentConsumersCount.Invoke((MethodInvoker)(delegate () { textBoxCurrentConsumersCount.Text = "0"; }));

            printTimer.Stop();
            tasksPrintCountTimer.Stop();

            PCController.ShutDown();

            PrintURLs(null, null);
            PrintCountTasks(null, null);
        }

        private void PrintURLs(object sender, ElapsedEventArgs e)
        {
            var text = string.Empty;
            var count = printURLsCollection.Count;

            while (printURLsCollection.Count > 0)
            {
                printURLsCollection.TryTake(out string item);

                if (item != null)
                {
                    text += item + Environment.NewLine;
                }
            }

            try
            {
                richTextBoxLinqs.Invoke((MethodInvoker)(delegate () { richTextBoxLinqs.Text += text; }));
                numericUpDownCount.Invoke((MethodInvoker)(delegate () { numericUpDownCount.Value += count; }));
            }
            catch { }
        }

        public void AddLinq(string linq)
        {
            printURLsCollection.Add(linq);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PCController.ShutDown();
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            var text = textBoxFind.Text;

            if (text != "")
            {
                Find(text, richTextBoxLinqs.SelectionStart);
            }
        }

        private void Find(string text, int index)
        {
            var allLinqs = richTextBoxLinqs.Text.ToLower();
            text = text.ToLower();

            if (allLinqs.Contains(text))
            {
                index = allLinqs.IndexOf(text, index);

                if (index == -1)
                {
                    index = allLinqs.IndexOf(text);
                }

                richTextBoxLinqs.Select(index, text.Length);
                richTextBoxLinqs.Focus();
            }
        }

        private void ButtonAddProducer_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxCurrentProducersCount.Invoke((MethodInvoker)(delegate ()
                {
                    int newVal = (int.Parse(textBoxCurrentProducersCount.Text) + 1);

                    if (newVal == 10)
                    {
                        buttonAddProducer.Enabled = false;
                    }

                    textBoxCurrentProducersCount.Text = newVal.ToString();
                }));

                PCController.AddProducer();
            }
            catch { }
        }

        private void ButtonAddConsumer_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxCurrentConsumersCount.Invoke((MethodInvoker)(delegate ()
                {
                    int newVal = (int.Parse(textBoxCurrentConsumersCount.Text) + 1);

                    if (newVal == 10)
                    {
                        buttonAddProducer.Enabled = false;
                    }

                    textBoxCurrentConsumersCount.Text = newVal.ToString();
                }));

                PCController.AddConsumer();
            }
            catch { }
        }
    }
}
