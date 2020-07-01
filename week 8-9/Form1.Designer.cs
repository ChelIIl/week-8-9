namespace week_8_9
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.depos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.capit = new System.Windows.Forms.ComboBox();
            this.cur = new System.Windows.Forms.ComboBox();
            this.indus = new System.Windows.Forms.RadioButton();
            this.capitaliz = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма вкладов";
            // 
            // depos
            // 
            this.depos.Location = new System.Drawing.Point(185, 14);
            this.depos.Name = "depos";
            this.depos.Size = new System.Drawing.Size(119, 20);
            this.depos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Срок размещения";
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(223, 163);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(42, 20);
            this.percent.TabIndex = 3;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(221, 111);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(137, 20);
            this.date.TabIndex = 4;
            this.date.Value = new System.DateTime(2020, 6, 28, 17, 55, 8, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Процентная ставка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(271, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "% годовых";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(174, 300);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(117, 20);
            this.result.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Начисление процентов";
            // 
            // capit
            // 
            this.capit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.capit.FormattingEnabled = true;
            this.capit.Items.AddRange(new object[] {
            "раз в месяц",
            "раз в квартал",
            "раз в полгода",
            "раз в год",
            "в конце срока"});
            this.capit.Location = new System.Drawing.Point(240, 259);
            this.capit.Name = "capit";
            this.capit.Size = new System.Drawing.Size(98, 21);
            this.capit.TabIndex = 9;
            // 
            // cur
            // 
            this.cur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cur.FormattingEnabled = true;
            this.cur.Items.AddRange(new object[] {
            "рубли",
            "евро",
            "доллары"});
            this.cur.Location = new System.Drawing.Point(310, 13);
            this.cur.Name = "cur";
            this.cur.Size = new System.Drawing.Size(98, 23);
            this.cur.TabIndex = 10;
            // 
            // indus
            // 
            this.indus.AutoSize = true;
            this.indus.Checked = true;
            this.indus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indus.Location = new System.Drawing.Point(17, 215);
            this.indus.Name = "indus";
            this.indus.Size = new System.Drawing.Size(140, 20);
            this.indus.TabIndex = 13;
            this.indus.TabStop = true;
            this.indus.Text = "Простой процент";
            this.indus.UseVisualStyleBackColor = true;
            this.indus.CheckedChanged += new System.EventHandler(this.indus_CheckedChanged);
            // 
            // capitaliz
            // 
            this.capitaliz.AutoSize = true;
            this.capitaliz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capitaliz.Location = new System.Drawing.Point(163, 215);
            this.capitaliz.Name = "capitaliz";
            this.capitaliz.Size = new System.Drawing.Size(128, 20);
            this.capitaliz.TabIndex = 14;
            this.capitaliz.Text = "Капитализация";
            this.capitaliz.UseVisualStyleBackColor = true;
            this.capitaliz.CheckedChanged += new System.EventHandler(this.capitaliz_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(88, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Дата начала срока";
            // 
            // time
            // 
            this.time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time.FormattingEnabled = true;
            this.time.Items.AddRange(new object[] {
            "1 год",
            "2 года",
            "3 года"});
            this.time.Location = new System.Drawing.Point(212, 65);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(98, 21);
            this.time.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(223, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Рассчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Итоговая сумма";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(429, 410);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.capitaliz);
            this.Controls.Add(this.indus);
            this.Controls.Add(this.cur);
            this.Controls.Add(this.capit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Калькулятор вкладов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox percent;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox capit;
        private System.Windows.Forms.ComboBox cur;
        private System.Windows.Forms.RadioButton indus;
        private System.Windows.Forms.RadioButton capitaliz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox time;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}

