namespace HTTPParser
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.richTextBoxLinqs = new System.Windows.Forms.RichTextBox();
            this.panelURL = new System.Windows.Forms.Panel();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelStartLinq = new System.Windows.Forms.Label();
            this.panelParams = new System.Windows.Forms.Panel();
            this.textBoxStartLinq = new System.Windows.Forms.TextBox();
            this.buttonAddProducer = new System.Windows.Forms.Button();
            this.buttonAddConsumer = new System.Windows.Forms.Button();
            this.labelProducersCount = new System.Windows.Forms.Label();
            this.numericUpDownProducersCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownConsumersCount = new System.Windows.Forms.NumericUpDown();
            this.labelConsumersCount = new System.Windows.Forms.Label();
            this.labelCurrentProducersCount = new System.Windows.Forms.Label();
            this.textBoxCurrentProducersCount = new System.Windows.Forms.TextBox();
            this.labelCurrentConsumersCount = new System.Windows.Forms.Label();
            this.textBoxCurrentConsumersCount = new System.Windows.Forms.TextBox();
            this.textBoxCurrentProducersTask = new System.Windows.Forms.TextBox();
            this.labelCurrentProducersTasks = new System.Windows.Forms.Label();
            this.textBoxCurrentConsumersTasks = new System.Windows.Forms.TextBox();
            this.labelCurrentConsumersTasks = new System.Windows.Forms.Label();
            this.panelURL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.panelParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProducersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsumersCount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(6, 96);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(322, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // richTextBoxLinqs
            // 
            this.richTextBoxLinqs.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLinqs.Name = "richTextBoxLinqs";
            this.richTextBoxLinqs.ReadOnly = true;
            this.richTextBoxLinqs.Size = new System.Drawing.Size(509, 308);
            this.richTextBoxLinqs.TabIndex = 1;
            this.richTextBoxLinqs.Text = "";
            // 
            // panelURL
            // 
            this.panelURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelURL.Controls.Add(this.buttonFind);
            this.panelURL.Controls.Add(this.textBoxFind);
            this.panelURL.Controls.Add(this.numericUpDownCount);
            this.panelURL.Controls.Add(this.labelCount);
            this.panelURL.Controls.Add(this.richTextBoxLinqs);
            this.panelURL.Location = new System.Drawing.Point(349, 12);
            this.panelURL.Name = "panelURL";
            this.panelURL.Size = new System.Drawing.Size(509, 368);
            this.panelURL.TabIndex = 3;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(6, 339);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(107, 23);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFind.Location = new System.Drawing.Point(119, 341);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(387, 20);
            this.textBoxFind.TabIndex = 5;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCount.Enabled = false;
            this.numericUpDownCount.Location = new System.Drawing.Point(119, 315);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.ReadOnly = true;
            this.numericUpDownCount.Size = new System.Drawing.Size(387, 20);
            this.numericUpDownCount.TabIndex = 4;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(3, 317);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(107, 13);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Количество ссылок";
            // 
            // labelStartLinq
            // 
            this.labelStartLinq.AutoSize = true;
            this.labelStartLinq.Location = new System.Drawing.Point(3, 12);
            this.labelStartLinq.Name = "labelStartLinq";
            this.labelStartLinq.Size = new System.Drawing.Size(101, 13);
            this.labelStartLinq.TabIndex = 6;
            this.labelStartLinq.Text = "Стартовая ссылка";
            this.labelStartLinq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelParams
            // 
            this.panelParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelParams.Controls.Add(this.textBoxCurrentConsumersTasks);
            this.panelParams.Controls.Add(this.labelCurrentConsumersTasks);
            this.panelParams.Controls.Add(this.textBoxCurrentProducersTask);
            this.panelParams.Controls.Add(this.labelCurrentProducersTasks);
            this.panelParams.Controls.Add(this.textBoxCurrentConsumersCount);
            this.panelParams.Controls.Add(this.labelCurrentConsumersCount);
            this.panelParams.Controls.Add(this.textBoxCurrentProducersCount);
            this.panelParams.Controls.Add(this.labelCurrentProducersCount);
            this.panelParams.Controls.Add(this.numericUpDownConsumersCount);
            this.panelParams.Controls.Add(this.labelConsumersCount);
            this.panelParams.Controls.Add(this.numericUpDownProducersCount);
            this.panelParams.Controls.Add(this.labelProducersCount);
            this.panelParams.Controls.Add(this.buttonAddConsumer);
            this.panelParams.Controls.Add(this.buttonAddProducer);
            this.panelParams.Controls.Add(this.textBoxStartLinq);
            this.panelParams.Controls.Add(this.labelStartLinq);
            this.panelParams.Controls.Add(this.buttonStart);
            this.panelParams.Location = new System.Drawing.Point(12, 12);
            this.panelParams.Name = "panelParams";
            this.panelParams.Size = new System.Drawing.Size(331, 368);
            this.panelParams.TabIndex = 7;
            // 
            // textBoxStartLinq
            // 
            this.textBoxStartLinq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStartLinq.Location = new System.Drawing.Point(161, 9);
            this.textBoxStartLinq.Name = "textBoxStartLinq";
            this.textBoxStartLinq.Size = new System.Drawing.Size(167, 20);
            this.textBoxStartLinq.TabIndex = 6;
            this.textBoxStartLinq.Text = "https://twitter.com/";
            this.textBoxStartLinq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAddProducer
            // 
            this.buttonAddProducer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProducer.Location = new System.Drawing.Point(6, 125);
            this.buttonAddProducer.Name = "buttonAddProducer";
            this.buttonAddProducer.Size = new System.Drawing.Size(322, 23);
            this.buttonAddProducer.TabIndex = 7;
            this.buttonAddProducer.Text = "Добавить производителя";
            this.buttonAddProducer.UseVisualStyleBackColor = true;
            this.buttonAddProducer.Click += new System.EventHandler(this.ButtonAddProducer_Click);
            // 
            // buttonAddConsumer
            // 
            this.buttonAddConsumer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddConsumer.Location = new System.Drawing.Point(6, 154);
            this.buttonAddConsumer.Name = "buttonAddConsumer";
            this.buttonAddConsumer.Size = new System.Drawing.Size(322, 23);
            this.buttonAddConsumer.TabIndex = 8;
            this.buttonAddConsumer.Text = "Добавить потребителя";
            this.buttonAddConsumer.UseVisualStyleBackColor = true;
            this.buttonAddConsumer.Click += new System.EventHandler(this.ButtonAddConsumer_Click);
            // 
            // labelProducersCount
            // 
            this.labelProducersCount.AutoSize = true;
            this.labelProducersCount.Location = new System.Drawing.Point(3, 42);
            this.labelProducersCount.Name = "labelProducersCount";
            this.labelProducersCount.Size = new System.Drawing.Size(152, 13);
            this.labelProducersCount.TabIndex = 10;
            this.labelProducersCount.Text = "Количество производителей";
            this.labelProducersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownProducersCount
            // 
            this.numericUpDownProducersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownProducersCount.Location = new System.Drawing.Point(161, 40);
            this.numericUpDownProducersCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownProducersCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownProducersCount.Name = "numericUpDownProducersCount";
            this.numericUpDownProducersCount.Size = new System.Drawing.Size(167, 20);
            this.numericUpDownProducersCount.TabIndex = 6;
            this.numericUpDownProducersCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownProducersCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownConsumersCount
            // 
            this.numericUpDownConsumersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownConsumersCount.Location = new System.Drawing.Point(161, 70);
            this.numericUpDownConsumersCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownConsumersCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownConsumersCount.Name = "numericUpDownConsumersCount";
            this.numericUpDownConsumersCount.Size = new System.Drawing.Size(167, 20);
            this.numericUpDownConsumersCount.TabIndex = 11;
            this.numericUpDownConsumersCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownConsumersCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelConsumersCount
            // 
            this.labelConsumersCount.AutoSize = true;
            this.labelConsumersCount.Location = new System.Drawing.Point(3, 72);
            this.labelConsumersCount.Name = "labelConsumersCount";
            this.labelConsumersCount.Size = new System.Drawing.Size(139, 13);
            this.labelConsumersCount.TabIndex = 12;
            this.labelConsumersCount.Text = "Количество потребителей";
            this.labelConsumersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCurrentProducersCount
            // 
            this.labelCurrentProducersCount.AutoSize = true;
            this.labelCurrentProducersCount.Location = new System.Drawing.Point(3, 185);
            this.labelCurrentProducersCount.Name = "labelCurrentProducersCount";
            this.labelCurrentProducersCount.Size = new System.Drawing.Size(199, 13);
            this.labelCurrentProducersCount.TabIndex = 14;
            this.labelCurrentProducersCount.Text = "Текущее количество производителей";
            this.labelCurrentProducersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCurrentProducersCount
            // 
            this.textBoxCurrentProducersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentProducersCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentProducersCount.Location = new System.Drawing.Point(240, 185);
            this.textBoxCurrentProducersCount.Name = "textBoxCurrentProducersCount";
            this.textBoxCurrentProducersCount.ReadOnly = true;
            this.textBoxCurrentProducersCount.Size = new System.Drawing.Size(88, 13);
            this.textBoxCurrentProducersCount.TabIndex = 15;
            this.textBoxCurrentProducersCount.Text = "0";
            this.textBoxCurrentProducersCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCurrentConsumersCount
            // 
            this.labelCurrentConsumersCount.AutoSize = true;
            this.labelCurrentConsumersCount.Location = new System.Drawing.Point(3, 210);
            this.labelCurrentConsumersCount.Name = "labelCurrentConsumersCount";
            this.labelCurrentConsumersCount.Size = new System.Drawing.Size(186, 13);
            this.labelCurrentConsumersCount.TabIndex = 16;
            this.labelCurrentConsumersCount.Text = "Текущее количество потребителей";
            this.labelCurrentConsumersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCurrentConsumersCount
            // 
            this.textBoxCurrentConsumersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentConsumersCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentConsumersCount.Location = new System.Drawing.Point(240, 210);
            this.textBoxCurrentConsumersCount.Name = "textBoxCurrentConsumersCount";
            this.textBoxCurrentConsumersCount.ReadOnly = true;
            this.textBoxCurrentConsumersCount.Size = new System.Drawing.Size(88, 13);
            this.textBoxCurrentConsumersCount.TabIndex = 17;
            this.textBoxCurrentConsumersCount.Text = "0";
            this.textBoxCurrentConsumersCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCurrentProducersTask
            // 
            this.textBoxCurrentProducersTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentProducersTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentProducersTask.Location = new System.Drawing.Point(240, 235);
            this.textBoxCurrentProducersTask.Name = "textBoxCurrentProducersTask";
            this.textBoxCurrentProducersTask.ReadOnly = true;
            this.textBoxCurrentProducersTask.Size = new System.Drawing.Size(88, 13);
            this.textBoxCurrentProducersTask.TabIndex = 19;
            this.textBoxCurrentProducersTask.Text = "0";
            this.textBoxCurrentProducersTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCurrentProducersTasks
            // 
            this.labelCurrentProducersTasks.AutoSize = true;
            this.labelCurrentProducersTasks.Location = new System.Drawing.Point(3, 235);
            this.labelCurrentProducersTasks.Name = "labelCurrentProducersTasks";
            this.labelCurrentProducersTasks.Size = new System.Drawing.Size(231, 13);
            this.labelCurrentProducersTasks.TabIndex = 18;
            this.labelCurrentProducersTasks.Text = "Текущее количество задач производителей";
            this.labelCurrentProducersTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCurrentConsumersTasks
            // 
            this.textBoxCurrentConsumersTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentConsumersTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentConsumersTasks.Location = new System.Drawing.Point(240, 260);
            this.textBoxCurrentConsumersTasks.Name = "textBoxCurrentConsumersTasks";
            this.textBoxCurrentConsumersTasks.ReadOnly = true;
            this.textBoxCurrentConsumersTasks.Size = new System.Drawing.Size(88, 13);
            this.textBoxCurrentConsumersTasks.TabIndex = 21;
            this.textBoxCurrentConsumersTasks.Text = "0";
            this.textBoxCurrentConsumersTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCurrentConsumersTasks
            // 
            this.labelCurrentConsumersTasks.AutoSize = true;
            this.labelCurrentConsumersTasks.Location = new System.Drawing.Point(3, 260);
            this.labelCurrentConsumersTasks.Name = "labelCurrentConsumersTasks";
            this.labelCurrentConsumersTasks.Size = new System.Drawing.Size(218, 13);
            this.labelCurrentConsumersTasks.TabIndex = 20;
            this.labelCurrentConsumersTasks.Text = "Текущее количество задач потребителей";
            this.labelCurrentConsumersTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 386);
            this.Controls.Add(this.panelParams);
            this.Controls.Add(this.panelURL);
            this.Name = "MainForm";
            this.Text = "Поисковик";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panelURL.ResumeLayout(false);
            this.panelURL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.panelParams.ResumeLayout(false);
            this.panelParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProducersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsumersCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox richTextBoxLinqs;
        private System.Windows.Forms.Panel panelURL;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelStartLinq;
        private System.Windows.Forms.Panel panelParams;
        private System.Windows.Forms.TextBox textBoxStartLinq;
        private System.Windows.Forms.TextBox textBoxCurrentProducersCount;
        private System.Windows.Forms.Label labelCurrentProducersCount;
        private System.Windows.Forms.NumericUpDown numericUpDownConsumersCount;
        private System.Windows.Forms.Label labelConsumersCount;
        private System.Windows.Forms.NumericUpDown numericUpDownProducersCount;
        private System.Windows.Forms.Label labelProducersCount;
        private System.Windows.Forms.Button buttonAddConsumer;
        private System.Windows.Forms.Button buttonAddProducer;
        private System.Windows.Forms.TextBox textBoxCurrentConsumersCount;
        private System.Windows.Forms.Label labelCurrentConsumersCount;
        private System.Windows.Forms.TextBox textBoxCurrentConsumersTasks;
        private System.Windows.Forms.Label labelCurrentConsumersTasks;
        private System.Windows.Forms.TextBox textBoxCurrentProducersTask;
        private System.Windows.Forms.Label labelCurrentProducersTasks;
    }
}

